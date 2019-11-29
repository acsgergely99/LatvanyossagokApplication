namespace MySQLApp
{
    partial class Form1
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
            this.rendezokHozzaadButton = new System.Windows.Forms.Button();
            this.nevlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SzuletesDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nevTextBox = new System.Windows.Forms.TextBox();
            this.szarmazasTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RendezoListBox = new System.Windows.Forms.ListBox();
            this.rendezoTorlesButton = new System.Windows.Forms.Button();
            this.FilmListBox = new System.Windows.Forms.ListBox();
            this.FilmTorlesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rendezokHozzaadButton
            // 
            this.rendezokHozzaadButton.Location = new System.Drawing.Point(397, 118);
            this.rendezokHozzaadButton.Name = "rendezokHozzaadButton";
            this.rendezokHozzaadButton.Size = new System.Drawing.Size(75, 23);
            this.rendezokHozzaadButton.TabIndex = 0;
            this.rendezokHozzaadButton.Text = "Hozzáad";
            this.rendezokHozzaadButton.UseVisualStyleBackColor = true;
            // 
            // nevlabel
            // 
            this.nevlabel.AutoSize = true;
            this.nevlabel.Location = new System.Drawing.Point(225, 29);
            this.nevlabel.Name = "nevlabel";
            this.nevlabel.Size = new System.Drawing.Size(30, 13);
            this.nevlabel.TabIndex = 2;
            this.nevlabel.Text = "Név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Születés:";
            // 
            // SzuletesDateTimePicker
            // 
            this.SzuletesDateTimePicker.Location = new System.Drawing.Point(272, 51);
            this.SzuletesDateTimePicker.Name = "SzuletesDateTimePicker";
            this.SzuletesDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.SzuletesDateTimePicker.TabIndex = 4;
            // 
            // nevTextBox
            // 
            this.nevTextBox.Location = new System.Drawing.Point(272, 22);
            this.nevTextBox.Name = "nevTextBox";
            this.nevTextBox.Size = new System.Drawing.Size(200, 20);
            this.nevTextBox.TabIndex = 5;
            // 
            // szarmazasTextBox
            // 
            this.szarmazasTextBox.Location = new System.Drawing.Point(272, 82);
            this.szarmazasTextBox.Name = "szarmazasTextBox";
            this.szarmazasTextBox.Size = new System.Drawing.Size(200, 20);
            this.szarmazasTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Származás:";
            // 
            // RendezoListBox
            // 
            this.RendezoListBox.FormattingEnabled = true;
            this.RendezoListBox.Location = new System.Drawing.Point(12, 22);
            this.RendezoListBox.Name = "RendezoListBox";
            this.RendezoListBox.Size = new System.Drawing.Size(176, 225);
            this.RendezoListBox.TabIndex = 8;
            this.RendezoListBox.SelectedIndexChanged += new System.EventHandler(this.RendezoListBox_SelectedIndexChanged);
            // 
            // rendezoTorlesButton
            // 
            this.rendezoTorlesButton.Location = new System.Drawing.Point(12, 262);
            this.rendezoTorlesButton.Name = "rendezoTorlesButton";
            this.rendezoTorlesButton.Size = new System.Drawing.Size(176, 26);
            this.rendezoTorlesButton.TabIndex = 9;
            this.rendezoTorlesButton.Text = "Törlés";
            this.rendezoTorlesButton.UseVisualStyleBackColor = true;
            this.rendezoTorlesButton.Click += new System.EventHandler(this.rendezoTorlesButton_Click);
            // 
            // FilmListBox
            // 
            this.FilmListBox.FormattingEnabled = true;
            this.FilmListBox.Location = new System.Drawing.Point(502, 22);
            this.FilmListBox.Name = "FilmListBox";
            this.FilmListBox.Size = new System.Drawing.Size(194, 238);
            this.FilmListBox.TabIndex = 10;
            this.FilmListBox.SelectedIndexChanged += new System.EventHandler(this.FilmListBox_SelectedIndexChanged);
            // 
            // FilmTorlesButton
            // 
            this.FilmTorlesButton.Location = new System.Drawing.Point(502, 266);
            this.FilmTorlesButton.Name = "FilmTorlesButton";
            this.FilmTorlesButton.Size = new System.Drawing.Size(194, 22);
            this.FilmTorlesButton.TabIndex = 11;
            this.FilmTorlesButton.Text = "Törlés";
            this.FilmTorlesButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(951, 498);
            this.Controls.Add(this.FilmTorlesButton);
            this.Controls.Add(this.FilmListBox);
            this.Controls.Add(this.rendezoTorlesButton);
            this.Controls.Add(this.RendezoListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szarmazasTextBox);
            this.Controls.Add(this.nevTextBox);
            this.Controls.Add(this.SzuletesDateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nevlabel);
            this.Controls.Add(this.rendezokHozzaadButton);
            this.Name = "Form1";
            this.Click += new System.EventHandler(this.RendezoHozzaadButton_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rendezokHozzaadButton;
        private System.Windows.Forms.Label nevlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker SzuletesDateTimePicker;
        private System.Windows.Forms.TextBox nevTextBox;
        private System.Windows.Forms.TextBox szarmazasTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RendezoListBox;
        private System.Windows.Forms.Button rendezoTorlesButton;
        private System.Windows.Forms.ListBox FilmListBox;
        private System.Windows.Forms.Button FilmTorlesButton;
    }
}

