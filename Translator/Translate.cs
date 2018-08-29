using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Web;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Translator
{
    public class Language
    {
        public string long_name { get; set; }
        public string shortened_name { get; set; }
    }

    public class Base
    {
        public List<Language> language { get; set; }
    }

    class Translate
    {
        public string input { get; set; }
        public string output { get; set; }
        public string text { get; set; }
        string[] part { get; set; }
        bool auto { get; set; }

        public Translate(string i, string o, string t, bool a)
        {
            input = i;
            output = o;
            text = t;
            auto = a;
            if ((t.Length / 1040) == 0)
            {
                part = new string[1];
                part[0] = t;
            }
            else
            {
                part = new string[(t.Length / 1040) + 1];
                for (int k = 0; k < part.Length - 1 ; k++)
                {
                    for (int j = 0; j < 1040; j++)
                    {
                        part[k] += t[j + (k * 1040)];
                        
                    }
                }
                part[part.Length-1] = text.Remove(0, ((part.Length - 1) * 1040));
            }
        }

        public string Make_Transloation()
        {
            try
            {
                string wynik = "";
                for (int k = 0; k < part.Length ; k++)
                {
                    string html = "";
                    string url = string.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", Identify_lang(input), Identify_lang(output), HttpUtility.UrlEncode(part[k]));
                    WebClient web = new WebClient();
                    web.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                    web.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                    web.Encoding = Encoding.UTF8;
                    html = web.DownloadString(url);
                    wynik += Formating_text_output(html);
                }
                return wynik;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error translation: " + ex.Message + "\n");
                return null;
            }

        }

        private string Formating_text_output(string html)
        {
            string pom = "";
            var objects = JArray.Parse(html);
            int licznik = 0;
            try
            {
                do
                {
                    pom += objects[0][licznik][0].ToString();
                    licznik++;
                } while (objects[0][licznik][0].ToString() != "");
            }
            catch
            { }
            return pom;
        }

        public string Show_detect_lan()
        {
            load_language();
            try
            {
                string pom = "";
                string html = "";
                int dl_tlumaczenie = 0;
                string url = string.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}", "auto", Identify_lang(output), HttpUtility.UrlEncode(part[0]));
                WebClient web = new WebClient();
                web.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0");
                web.Headers.Add(HttpRequestHeader.AcceptCharset, "UTF-8");
                web.Encoding = Encoding.UTF8;
                html = web.DownloadString(url);
                dl_tlumaczenie = html.Length;
                pom = html[dl_tlumaczenie - 6] + "" + html[dl_tlumaczenie - 5];
                foreach(KeyValuePair<string,string> kvp in kraj_map)
                {
                    if(kvp.Value == pom)
                    {
                        pom = kvp.Key;
                    }
                }
                return pom;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error translation: " + ex.Message);
                return null;
            }
        }

        private string Identify_lang(string value)
        {
            string result = "";
            try
            {
                kraj_map.TryGetValue(value, out result);
                if (auto == false)
                {
                    return result;
                }
                else
                {
                    if (value == "auto")
                    {
                        return "auto";
                    }
                    else
                    {
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error translation: " + ex.Message);
                return null;
            }
        }

        public static IEnumerable<string> kraj
        {
            get
            {
                load_language();
                return kraj_map.Keys.OrderBy(p => p);
            }
        }

        private static void load_language()
        {
            try
            {
                if (kraj_map == null)
                {
                    kraj_map = new Dictionary<string, string>();
                    String JSONstring = File.ReadAllText("data.json");
                    var ser = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<Base>(JSONstring);
                    for (int k = 0; k < ser.language.Count; k++)
                    {
                        kraj_map.Add(ser.language[k].long_name, ser.language[k].shortened_name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error set Dictionary function: " + ex.Message);
            }
        }

        private static Dictionary<string, string> kraj_map;
    }
}
