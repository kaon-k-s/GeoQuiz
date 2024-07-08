namespace GeoQuiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStart = new Button();
            label1 = new Label();
            label2 = new Label();
            gbFrageTyp = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            gbAntTyp = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            gbKontinent = new GroupBox();
            radioButton13 = new RadioButton();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            gbFrageTyp.SuspendLayout();
            gbAntTyp.SuspendLayout();
            gbKontinent.SuspendLayout();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.LimeGreen;
            btnStart.Location = new Point(415, 379);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(157, 32);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 13.8F);
            label1.Location = new Point(84, 34);
            label1.Name = "label1";
            label1.Size = new Size(68, 24);
            label1.TabIndex = 3;
            label1.Text = "GeoQuiz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 67);
            label2.Name = "label2";
            label2.Size = new Size(219, 15);
            label2.TabIndex = 4;
            label2.Text = "Please select question and answer types:";
            // 
            // gbFrageTyp
            // 
            gbFrageTyp.BackColor = SystemColors.HighlightText;
            gbFrageTyp.Controls.Add(radioButton3);
            gbFrageTyp.Controls.Add(radioButton2);
            gbFrageTyp.Controls.Add(radioButton1);
            gbFrageTyp.Location = new Point(84, 118);
            gbFrageTyp.Margin = new Padding(3, 2, 3, 2);
            gbFrageTyp.Name = "gbFrageTyp";
            gbFrageTyp.Padding = new Padding(3, 2, 3, 2);
            gbFrageTyp.Size = new Size(488, 55);
            gbFrageTyp.TabIndex = 5;
            gbFrageTyp.TabStop = false;
            gbFrageTyp.Text = "FrageTyp";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(283, 22);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(60, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Flagge";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(137, 22);
            radioButton2.Margin = new Padding(3, 2, 3, 2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(84, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Hauptstadt";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(27, 22);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Land";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // gbAntTyp
            // 
            gbAntTyp.BackColor = SystemColors.ControlLightLight;
            gbAntTyp.Controls.Add(radioButton6);
            gbAntTyp.Controls.Add(radioButton5);
            gbAntTyp.Controls.Add(radioButton4);
            gbAntTyp.Location = new Point(84, 185);
            gbAntTyp.Margin = new Padding(3, 2, 3, 2);
            gbAntTyp.Name = "gbAntTyp";
            gbAntTyp.Padding = new Padding(3, 2, 3, 2);
            gbAntTyp.Size = new Size(488, 52);
            gbAntTyp.TabIndex = 6;
            gbAntTyp.TabStop = false;
            gbAntTyp.Text = "AntwortTyp";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(284, 20);
            radioButton6.Margin = new Padding(3, 2, 3, 2);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(60, 19);
            radioButton6.TabIndex = 2;
            radioButton6.TabStop = true;
            radioButton6.Text = "Flagge";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(138, 20);
            radioButton5.Margin = new Padding(3, 2, 3, 2);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(84, 19);
            radioButton5.TabIndex = 1;
            radioButton5.TabStop = true;
            radioButton5.Text = "Hauptstadt";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(28, 20);
            radioButton4.Margin = new Padding(3, 2, 3, 2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(51, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Land";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // gbKontinent
            // 
            gbKontinent.BackColor = SystemColors.ControlLightLight;
            gbKontinent.Controls.Add(radioButton13);
            gbKontinent.Controls.Add(radioButton12);
            gbKontinent.Controls.Add(radioButton11);
            gbKontinent.Controls.Add(radioButton10);
            gbKontinent.Controls.Add(radioButton9);
            gbKontinent.Controls.Add(radioButton8);
            gbKontinent.Controls.Add(radioButton7);
            gbKontinent.Location = new Point(84, 254);
            gbKontinent.Name = "gbKontinent";
            gbKontinent.Size = new Size(488, 93);
            gbKontinent.TabIndex = 7;
            gbKontinent.TabStop = false;
            gbKontinent.Text = "Kontinent";
            // 
            // radioButton13
            // 
            radioButton13.AutoSize = true;
            radioButton13.Location = new Point(411, 38);
            radioButton13.Name = "radioButton13";
            radioButton13.Size = new Size(45, 19);
            radioButton13.TabIndex = 6;
            radioButton13.TabStop = true;
            radioButton13.Text = "Alle";
            radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(283, 57);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(93, 19);
            radioButton12.TabIndex = 5;
            radioButton12.TabStop = true;
            radioButton12.Text = "Suedamerika";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(148, 57);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(56, 19);
            radioButton11.TabIndex = 4;
            radioButton11.TabStop = true;
            radioButton11.Text = "Afrika";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(17, 57);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(94, 19);
            radioButton10.TabIndex = 3;
            radioButton10.TabStop = true;
            radioButton10.Text = "Nordamerika";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(283, 22);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(74, 19);
            radioButton9.TabIndex = 2;
            radioButton9.TabStop = true;
            radioButton9.Text = "Ozeanien";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(148, 22);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(54, 19);
            radioButton8.TabIndex = 1;
            radioButton8.TabStop = true;
            radioButton8.Text = "Asien";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(17, 22);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(62, 19);
            radioButton7.TabIndex = 0;
            radioButton7.TabStop = true;
            radioButton7.Text = "Europa";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(682, 446);
            Controls.Add(gbKontinent);
            Controls.Add(gbAntTyp);
            Controls.Add(gbFrageTyp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            gbFrageTyp.ResumeLayout(false);
            gbFrageTyp.PerformLayout();
            gbAntTyp.ResumeLayout(false);
            gbAntTyp.PerformLayout();
            gbKontinent.ResumeLayout(false);
            gbKontinent.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnStart;
        private Label label1;
        private Label label2;
        private GroupBox gbFrageTyp;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox gbAntTyp;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private GroupBox gbKontinent;
        private RadioButton radioButton13;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
    }
}