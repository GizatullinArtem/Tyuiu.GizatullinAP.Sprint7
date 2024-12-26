namespace Tyuiu.GizatullinAP.Sprint7.Project.V14
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            label1 = new Label();
            buttonOK_GAP = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // buttonOK_GAP
            // 
            buttonOK_GAP.BackColor = SystemColors.ButtonFace;
            buttonOK_GAP.Image = (Image)resources.GetObject("buttonOK_GAP.Image");
            buttonOK_GAP.Location = new Point(459, 165);
            buttonOK_GAP.Name = "buttonOK_GAP";
            buttonOK_GAP.Size = new Size(47, 50);
            buttonOK_GAP.TabIndex = 2;
            buttonOK_GAP.UseVisualStyleBackColor = false;
            buttonOK_GAP.Click += buttonOK_GAP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 24);
            label2.Name = "label2";
            label2.Size = new Size(302, 120);
            label2.TabIndex = 5;
            label2.Text = "Разработчик: Гизатуллин А. П.\r\n\r\nГруппа ИСПб-24-1\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\n\r\nТюменский индустриальный университет (с) 2024\r\nВысшая школа цифровых технологий (с) 2024";
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 237);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK_GAP);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormInfo";
            Text = "Выполнил Гизатуллин А. П.  ИСПб-24-1 ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK_GAP;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
