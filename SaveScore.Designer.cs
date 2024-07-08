namespace GeoQuiz
{
    partial class SaveScore
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
            tbNeuSpieler = new TextBox();
            btnSaveSpieler = new Button();
            libPersonHighSc = new ListBox();
            libAllHighSc = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // tbNeuSpieler
            // 
            tbNeuSpieler.Location = new Point(77, 81);
            tbNeuSpieler.Margin = new Padding(3, 2, 3, 2);
            tbNeuSpieler.Name = "tbNeuSpieler";
            tbNeuSpieler.Size = new Size(188, 23);
            tbNeuSpieler.TabIndex = 0;
            tbNeuSpieler.Text = "Name...";
            // 
            // btnSaveSpieler
            // 
            btnSaveSpieler.BackColor = Color.LimeGreen;
            btnSaveSpieler.Location = new Point(343, 80);
            btnSaveSpieler.Margin = new Padding(3, 2, 3, 2);
            btnSaveSpieler.Name = "btnSaveSpieler";
            btnSaveSpieler.Size = new Size(141, 22);
            btnSaveSpieler.TabIndex = 1;
            btnSaveSpieler.Text = "OK";
            btnSaveSpieler.UseVisualStyleBackColor = false;
            btnSaveSpieler.Click += btnSaveSpieler_Click;
            // 
            // libPersonHighSc
            // 
            libPersonHighSc.FormattingEnabled = true;
            libPersonHighSc.ItemHeight = 15;
            libPersonHighSc.Location = new Point(80, 162);
            libPersonHighSc.Margin = new Padding(3, 2, 3, 2);
            libPersonHighSc.Name = "libPersonHighSc";
            libPersonHighSc.Size = new Size(218, 214);
            libPersonHighSc.TabIndex = 2;
            // 
            // libAllHighSc
            // 
            libAllHighSc.FormattingEnabled = true;
            libAllHighSc.ItemHeight = 15;
            libAllHighSc.Location = new Point(384, 162);
            libAllHighSc.Margin = new Padding(3, 2, 3, 2);
            libAllHighSc.Name = "libAllHighSc";
            libAllHighSc.Size = new Size(235, 214);
            libAllHighSc.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 128);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 4;
            label1.Text = "Highscores: Personal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 128);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 5;
            label2.Text = "Highscores: All";
            // 
            // SaveScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(684, 409);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(libAllHighSc);
            Controls.Add(libPersonHighSc);
            Controls.Add(btnSaveSpieler);
            Controls.Add(tbNeuSpieler);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SaveScore";
            Text = "Name";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNeuSpieler;
        private Button btnSaveSpieler;
        private ListBox libPersonHighSc;
        private ListBox libAllHighSc;
        private Label label1;
        private Label label2;
    }
}