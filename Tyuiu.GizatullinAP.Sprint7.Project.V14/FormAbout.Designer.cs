﻿namespace Tyuiu.GizatullinAP.Sprint7.Project.V14
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOK_GAP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 153);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonOK_GAP
            // 
            this.buttonOK_GAP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOK_GAP.Location = new System.Drawing.Point(430, 236);
            this.buttonOK_GAP.Name = "buttonOK_GAP";
            this.buttonOK_GAP.Size = new System.Drawing.Size(156, 53);
            this.buttonOK_GAP.TabIndex = 1;
            this.buttonOK_GAP.Text = "OK";
            this.buttonOK_GAP.UseVisualStyleBackColor = false;
            this.buttonOK_GAP.Click += new System.EventHandler(this.buttonOK_GAP_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 301);
            this.Controls.Add(this.buttonOK_GAP);
            this.Controls.Add(this.label1);
            this.Name = "FormAbout";
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOK_GAP;
    }
}