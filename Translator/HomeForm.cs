using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Translator
{
    public partial class Tłumacz : Form
    {
        public Tłumacz()
        {
            InitializeComponent();
            set_languages();
            Detect_lang.Checked = false;
            Input_Lang.SelectedIndex = 44;
            Output_Lang.SelectedIndex = 15;
        }

        private void set_languages()
        {
            
            Input_Lang.Items.AddRange(Translate.kraj.ToArray());
            Output_Lang.Items.AddRange(Translate.kraj.ToArray());
        }

        private void Translate_bt_Click(object sender, EventArgs e)
        {
            if (Input_text.Text != "")
            {
                if (Detect_lang.Checked == false)
                {
                    Translate asd = new Translate(Input_Lang.Text, Output_Lang.Text, Input_text.Text, false);
                    Output_text.Text = asd.Make_Transloation();
                }
                else
                {
                    Translate asd = new Translate("auto", Output_Lang.Text, Input_text.Text, true);
                    Output_text.Text = asd.Make_Transloation();
                    Output_detect_lang.Text = asd.Show_detect_lan();
                }
            }
            else
            {
                MessageBox.Show("Podaj tekst do Tłumaczenia !!");
            }
        }

        private void Detect_lang_CheckedChanged(object sender, EventArgs e)
        {
            if(Detect_lang.Checked == false)
            {
                Input_Lang.Enabled = true;
            }
            else
            {
                Input_Lang.Enabled = false;
            }
        }

        private void wczytajPlikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = "c:\\";
            openFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK )
            {
                Input_text.Text = File.ReadAllText(openFile.FileName);
            }
        }

        private void zapiszTłumaczenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt files (*.txt)|*.txt";
            saveFile.Title = "Save Text Translate";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFile.FileName, Output_text.Text);
            }
        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Tłumacz_DragDrop(object sender, DragEventArgs e)
        {
            Input_text.Clear();
            try
            {
                Array a = (Array)e.Data.GetData(DataFormats.FileDrop);
                if (a != null)
                {
                    string s = a.GetValue(0).ToString();
                    StreamReader StreamReader1 = new StreamReader(s);
                    Input_text.Text = StreamReader1.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in DragDrop function: " + ex.Message);
            }
        }

        private void Tłumacz_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Input_text.Clear();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program tłumaczy dowolny tekst \nFunkcja wykrywania języka wprowadzanego tekstu \nWczytanie z pliku txt testu do tłumaczneia \nZapis tłumaczenia do pliku\nMożliwość przeciągniecia pliku tekstowego na formatkę(pomijamy obszar do wpisywania tekstu \n");
        }

        private void Input_text_TextChanged(object sender, EventArgs e)
        {

            if (Input_text.Text != "")
            {
                if (Detect_lang.Checked == false)
                {
                    Translate asd = new Translate(Input_Lang.Text, Output_Lang.Text, Input_text.Text, false);
                    Output_text.Text = asd.Make_Transloation();
                }
                else
                {
                    Translate asd = new Translate("auto", Output_Lang.Text, Input_text.Text, true);
                    Output_text.Text = asd.Make_Transloation();
                    Output_detect_lang.Text = asd.Show_detect_lan();
                }
            }
            else
            {
                MessageBox.Show("Podaj tekst do Tłumaczenia !!");
            }
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            string pom = Input_Lang.Text;
            string pom2 = Output_Lang.Text;
            Input_Lang.Text = pom2;
            Output_Lang.Text = pom;
        }
    }
}
