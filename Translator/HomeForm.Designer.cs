namespace Translator
{
    partial class Tłumacz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Translate_bt = new System.Windows.Forms.Button();
            this.Input_text = new System.Windows.Forms.RichTextBox();
            this.Output_text = new System.Windows.Forms.RichTextBox();
            this.Input_Lang = new System.Windows.Forms.ComboBox();
            this.Output_Lang = new System.Windows.Forms.ComboBox();
            this.Detect_lang = new System.Windows.Forms.CheckBox();
            this.Output_detect_lang = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszTłumaczenieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.koniecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Reverse = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Translate_bt
            // 
            this.Translate_bt.Location = new System.Drawing.Point(12, 35);
            this.Translate_bt.Name = "Translate_bt";
            this.Translate_bt.Size = new System.Drawing.Size(75, 23);
            this.Translate_bt.TabIndex = 0;
            this.Translate_bt.Text = "Tłumacz";
            this.Translate_bt.UseVisualStyleBackColor = true;
            this.Translate_bt.Click += new System.EventHandler(this.Translate_bt_Click);
            // 
            // Input_text
            // 
            this.Input_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Input_text.Location = new System.Drawing.Point(12, 91);
            this.Input_text.Name = "Input_text";
            this.Input_text.Size = new System.Drawing.Size(320, 331);
            this.Input_text.TabIndex = 1;
            this.Input_text.Text = "";
            this.Input_text.TextChanged += new System.EventHandler(this.Input_text_TextChanged);
            // 
            // Output_text
            // 
            this.Output_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Output_text.CausesValidation = false;
            this.Output_text.Location = new System.Drawing.Point(413, 91);
            this.Output_text.Name = "Output_text";
            this.Output_text.ReadOnly = true;
            this.Output_text.Size = new System.Drawing.Size(320, 331);
            this.Output_text.TabIndex = 2;
            this.Output_text.Text = "";
            // 
            // Input_Lang
            // 
            this.Input_Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Input_Lang.FormattingEnabled = true;
            this.Input_Lang.Location = new System.Drawing.Point(12, 64);
            this.Input_Lang.Name = "Input_Lang";
            this.Input_Lang.Size = new System.Drawing.Size(121, 21);
            this.Input_Lang.TabIndex = 3;
            // 
            // Output_Lang
            // 
            this.Output_Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Output_Lang.FormattingEnabled = true;
            this.Output_Lang.Location = new System.Drawing.Point(413, 64);
            this.Output_Lang.Name = "Output_Lang";
            this.Output_Lang.Size = new System.Drawing.Size(121, 21);
            this.Output_Lang.TabIndex = 4;
            // 
            // Detect_lang
            // 
            this.Detect_lang.AutoSize = true;
            this.Detect_lang.Location = new System.Drawing.Point(322, 48);
            this.Detect_lang.Name = "Detect_lang";
            this.Detect_lang.Size = new System.Drawing.Size(85, 17);
            this.Detect_lang.TabIndex = 5;
            this.Detect_lang.Text = "Wykryj język";
            this.Detect_lang.UseVisualStyleBackColor = true;
            this.Detect_lang.CheckedChanged += new System.EventHandler(this.Detect_lang_CheckedChanged);
            // 
            // Output_detect_lang
            // 
            this.Output_detect_lang.AutoSize = true;
            this.Output_detect_lang.Location = new System.Drawing.Point(413, 45);
            this.Output_detect_lang.Name = "Output_detect_lang";
            this.Output_detect_lang.Size = new System.Drawing.Size(0, 13);
            this.Output_detect_lang.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajPlikToolStripMenuItem,
            this.zapiszTłumaczenieToolStripMenuItem,
            this.toolStripMenuItem1,
            this.koniecToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wczytajPlikToolStripMenuItem
            // 
            this.wczytajPlikToolStripMenuItem.Name = "wczytajPlikToolStripMenuItem";
            this.wczytajPlikToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.wczytajPlikToolStripMenuItem.Text = "Wczytaj Plik";
            this.wczytajPlikToolStripMenuItem.Click += new System.EventHandler(this.wczytajPlikToolStripMenuItem_Click);
            // 
            // zapiszTłumaczenieToolStripMenuItem
            // 
            this.zapiszTłumaczenieToolStripMenuItem.Name = "zapiszTłumaczenieToolStripMenuItem";
            this.zapiszTłumaczenieToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.zapiszTłumaczenieToolStripMenuItem.Text = "Zapisz tłumaczenie";
            this.zapiszTłumaczenieToolStripMenuItem.Click += new System.EventHandler(this.zapiszTłumaczenieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // koniecToolStripMenuItem
            // 
            this.koniecToolStripMenuItem.Name = "koniecToolStripMenuItem";
            this.koniecToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.koniecToolStripMenuItem.Text = "Koniec";
            this.koniecToolStripMenuItem.Click += new System.EventHandler(this.koniecToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Czyść tekst";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reverse
            // 
            this.Reverse.Location = new System.Drawing.Point(338, 91);
            this.Reverse.Name = "Reverse";
            this.Reverse.Size = new System.Drawing.Size(69, 23);
            this.Reverse.TabIndex = 9;
            this.Reverse.Text = "<->";
            this.Reverse.UseVisualStyleBackColor = true;
            this.Reverse.Click += new System.EventHandler(this.Reverse_Click);
            // 
            // Tłumacz
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 434);
            this.Controls.Add(this.Reverse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Output_detect_lang);
            this.Controls.Add(this.Detect_lang);
            this.Controls.Add(this.Output_Lang);
            this.Controls.Add(this.Input_Lang);
            this.Controls.Add(this.Output_text);
            this.Controls.Add(this.Input_text);
            this.Controls.Add(this.Translate_bt);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Tłumacz";
            this.Text = "Tłumacz";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Tłumacz_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Tłumacz_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Translate_bt;
        private System.Windows.Forms.RichTextBox Input_text;
        private System.Windows.Forms.RichTextBox Output_text;
        private System.Windows.Forms.ComboBox Input_Lang;
        private System.Windows.Forms.ComboBox Output_Lang;
        private System.Windows.Forms.CheckBox Detect_lang;
        private System.Windows.Forms.Label Output_detect_lang;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszTłumaczenieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reverse;
    }
}

