namespace GeoQuiz
{
    partial class FragenDisplayForm
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
            lblFrage = new Label();
            rbOption1 = new RadioButton();
            rbOption2 = new RadioButton();
            rbOption3 = new RadioButton();
            rbOption4 = new RadioButton();
            btnSubmit = new Button();
            pb1 = new PictureBox();
            pb2 = new PictureBox();
            pb3 = new PictureBox();
            pb4 = new PictureBox();
            pbFrage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFrage).BeginInit();
            SuspendLayout();
            // 
            // lblFrage
            // 
            lblFrage.AutoSize = true;
            lblFrage.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrage.Location = new Point(56, 56);
            lblFrage.Name = "lblFrage";
            lblFrage.Size = new Size(176, 25);
            lblFrage.TabIndex = 1;
            lblFrage.Text = "Click Weiter to start";
            // 
            // rbOption1
            // 
            rbOption1.AutoSize = true;
            rbOption1.Location = new Point(83, 154);
            rbOption1.Margin = new Padding(3, 2, 3, 2);
            rbOption1.Name = "rbOption1";
            rbOption1.Size = new Size(14, 13);
            rbOption1.TabIndex = 2;
            rbOption1.TabStop = true;
            rbOption1.UseVisualStyleBackColor = true;
            // 
            // rbOption2
            // 
            rbOption2.AutoSize = true;
            rbOption2.Location = new Point(240, 154);
            rbOption2.Margin = new Padding(3, 2, 3, 2);
            rbOption2.Name = "rbOption2";
            rbOption2.Size = new Size(14, 13);
            rbOption2.TabIndex = 3;
            rbOption2.TabStop = true;
            rbOption2.UseVisualStyleBackColor = true;
            // 
            // rbOption3
            // 
            rbOption3.AutoSize = true;
            rbOption3.Location = new Point(391, 154);
            rbOption3.Margin = new Padding(3, 2, 3, 2);
            rbOption3.Name = "rbOption3";
            rbOption3.Size = new Size(14, 13);
            rbOption3.TabIndex = 4;
            rbOption3.TabStop = true;
            rbOption3.UseVisualStyleBackColor = true;
            // 
            // rbOption4
            // 
            rbOption4.AutoSize = true;
            rbOption4.Location = new Point(545, 154);
            rbOption4.Margin = new Padding(3, 2, 3, 2);
            rbOption4.Name = "rbOption4";
            rbOption4.Size = new Size(14, 13);
            rbOption4.TabIndex = 5;
            rbOption4.TabStop = true;
            rbOption4.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.LimeGreen;
            btnSubmit.Font = new Font("Segoe UI", 9F);
            btnSubmit.Location = new Point(451, 52);
            btnSubmit.Margin = new Padding(3, 2, 3, 2);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(132, 38);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Weiter";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pb1
            // 
            pb1.Location = new Point(37, 187);
            pb1.Name = "pb1";
            pb1.Size = new Size(113, 74);
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb1.TabIndex = 7;
            pb1.TabStop = false;
            // 
            // pb2
            // 
            pb2.Location = new Point(192, 187);
            pb2.Name = "pb2";
            pb2.Size = new Size(114, 74);
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            pb2.TabIndex = 8;
            pb2.TabStop = false;
            // 
            // pb3
            // 
            pb3.Location = new Point(343, 187);
            pb3.Name = "pb3";
            pb3.Size = new Size(112, 74);
            pb3.SizeMode = PictureBoxSizeMode.Zoom;
            pb3.TabIndex = 9;
            pb3.TabStop = false;
            // 
            // pb4
            // 
            pb4.Location = new Point(499, 187);
            pb4.Name = "pb4";
            pb4.Size = new Size(113, 74);
            pb4.SizeMode = PictureBoxSizeMode.Zoom;
            pb4.TabIndex = 10;
            pb4.TabStop = false;
            // 
            // pbFrage
            // 
            pbFrage.Location = new Point(264, 41);
            pbFrage.Name = "pbFrage";
            pbFrage.Size = new Size(141, 80);
            pbFrage.SizeMode = PictureBoxSizeMode.Zoom;
            pbFrage.TabIndex = 11;
            pbFrage.TabStop = false;
            // 
            // FragenDisplayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(681, 338);
            Controls.Add(pbFrage);
            Controls.Add(pb4);
            Controls.Add(pb3);
            Controls.Add(pb2);
            Controls.Add(pb1);
            Controls.Add(btnSubmit);
            Controls.Add(rbOption4);
            Controls.Add(rbOption3);
            Controls.Add(rbOption2);
            Controls.Add(rbOption1);
            Controls.Add(lblFrage);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FragenDisplayForm";
            Text = "FragenDisplayForm";
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFrage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblFrage;
        private RadioButton rbOption1;
        private RadioButton rbOption2;
        private RadioButton rbOption3;
        private RadioButton rbOption4;
        private Button btnSubmit;
        private PictureBox pb1;
        private PictureBox pb2;
        private PictureBox pb3;
        private PictureBox pb4;
        private PictureBox pbFrage;
    }
}