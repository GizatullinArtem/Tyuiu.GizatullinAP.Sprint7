namespace Tyuiu.GizatullinAP.Sprint7.Project.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            label1 = new Label();
            buttonOK_GAP = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 8);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // buttonOK_GAP
            // 
            buttonOK_GAP.BackColor = SystemColors.ActiveCaption;
            buttonOK_GAP.Location = new Point(376, 221);
            buttonOK_GAP.Name = "buttonOK_GAP";
            buttonOK_GAP.Size = new Size(136, 50);
            buttonOK_GAP.TabIndex = 1;
            buttonOK_GAP.Text = "OK";
            buttonOK_GAP.UseVisualStyleBackColor = false;
            buttonOK_GAP.Click += buttonOK_GAP_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 23);
            label2.Name = "label2";
            label2.Size = new Size(492, 105);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 282);
            Controls.Add(label2);
            Controls.Add(buttonOK_GAP);
            Controls.Add(label1);
            Name = "FormAbout";
            Text = "Задание";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK_GAP;
        private Label label2;
    }
}
