namespace Tyuiu.GizatullinAP.Sprint7.Project.V14
{
    partial class FormMain
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
            this.buttonHelp_GAP = new System.Windows.Forms.Button();
            this.buttonOpen_GAP = new System.Windows.Forms.Button();
            this.groupBox_GAP = new System.Windows.Forms.GroupBox();
            this.buttonOp_GAP = new System.Windows.Forms.Button();
            this.dataGridView_GAP = new System.Windows.Forms.DataGridView();
            this.buttonAdd_GAP = new System.Windows.Forms.Button();
            this.buttonSave_GAP = new System.Windows.Forms.Button();
            this.buttonDelete_GAP = new System.Windows.Forms.Button();
            this.labelSearch_GAP = new System.Windows.Forms.Label();
            this.textBoxSearch_GAP = new System.Windows.Forms.TextBox();
            this.buttonInfo_GAP = new System.Windows.Forms.Button();
            this.openFileDialog_GAP = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_GAP = new System.Windows.Forms.SaveFileDialog();
            this.groupBox_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GAP)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHelp_GAP
            // 
            this.buttonHelp_GAP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonHelp_GAP.Location = new System.Drawing.Point(98, 21);
            this.buttonHelp_GAP.Name = "buttonHelp_GAP";
            this.buttonHelp_GAP.Size = new System.Drawing.Size(67, 54);
            this.buttonHelp_GAP.TabIndex = 0;
            this.buttonHelp_GAP.UseVisualStyleBackColor = false;
            this.buttonHelp_GAP.Click += new System.EventHandler(this.buttonHelp_GAP_Click);
            // 
            // buttonOpen_GAP
            // 
            this.buttonOpen_GAP.Location = new System.Drawing.Point(828, 296);
            this.buttonOpen_GAP.Name = "buttonOpen_GAP";
            this.buttonOpen_GAP.Size = new System.Drawing.Size(75, 49);
            this.buttonOpen_GAP.TabIndex = 2;
            this.buttonOpen_GAP.Text = "Открыть";
            this.buttonOpen_GAP.UseVisualStyleBackColor = true;
            // 
            // groupBox_GAP
            // 
            this.groupBox_GAP.Controls.Add(this.buttonOp_GAP);
            this.groupBox_GAP.Controls.Add(this.dataGridView_GAP);
            this.groupBox_GAP.Controls.Add(this.buttonAdd_GAP);
            this.groupBox_GAP.Controls.Add(this.buttonSave_GAP);
            this.groupBox_GAP.Controls.Add(this.buttonDelete_GAP);
            this.groupBox_GAP.Controls.Add(this.labelSearch_GAP);
            this.groupBox_GAP.Controls.Add(this.textBoxSearch_GAP);
            this.groupBox_GAP.Controls.Add(this.buttonHelp_GAP);
            this.groupBox_GAP.Controls.Add(this.buttonInfo_GAP);
            this.groupBox_GAP.Location = new System.Drawing.Point(12, 12);
            this.groupBox_GAP.Name = "groupBox_GAP";
            this.groupBox_GAP.Size = new System.Drawing.Size(1095, 575);
            this.groupBox_GAP.TabIndex = 3;
            this.groupBox_GAP.TabStop = false;
            // 
            // buttonOp_GAP
            // 
            this.buttonOp_GAP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonOp_GAP.Location = new System.Drawing.Point(192, 21);
            this.buttonOp_GAP.Name = "buttonOp_GAP";
            this.buttonOp_GAP.Size = new System.Drawing.Size(111, 56);
            this.buttonOp_GAP.TabIndex = 9;
            this.buttonOp_GAP.Text = "Открыть";
            this.buttonOp_GAP.UseVisualStyleBackColor = false;
            this.buttonOp_GAP.Click += new System.EventHandler(this.button_Click);
            // 
            // dataGridView_GAP
            // 
            this.dataGridView_GAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GAP.Location = new System.Drawing.Point(9, 86);
            this.dataGridView_GAP.Name = "dataGridView_GAP";
            this.dataGridView_GAP.RowHeadersWidth = 51;
            this.dataGridView_GAP.RowTemplate.Height = 24;
            this.dataGridView_GAP.Size = new System.Drawing.Size(903, 468);
            this.dataGridView_GAP.TabIndex = 8;
            // 
            // buttonAdd_GAP
            // 
            this.buttonAdd_GAP.BackColor = System.Drawing.Color.Tan;
            this.buttonAdd_GAP.Location = new System.Drawing.Point(560, 16);
            this.buttonAdd_GAP.Name = "buttonAdd_GAP";
            this.buttonAdd_GAP.Size = new System.Drawing.Size(120, 56);
            this.buttonAdd_GAP.TabIndex = 7;
            this.buttonAdd_GAP.Text = "Добавить строку";
            this.buttonAdd_GAP.UseVisualStyleBackColor = false;
            this.buttonAdd_GAP.Click += new System.EventHandler(this.buttonAdd_GAP_Click);
            // 
            // buttonSave_GAP
            // 
            this.buttonSave_GAP.BackColor = System.Drawing.Color.Chocolate;
            this.buttonSave_GAP.Location = new System.Drawing.Point(945, 471);
            this.buttonSave_GAP.Name = "buttonSave_GAP";
            this.buttonSave_GAP.Size = new System.Drawing.Size(123, 70);
            this.buttonSave_GAP.TabIndex = 6;
            this.buttonSave_GAP.Text = "Сохранить";
            this.buttonSave_GAP.UseVisualStyleBackColor = false;
            this.buttonSave_GAP.Click += new System.EventHandler(this.buttonSave_GAP_Click);
            // 
            // buttonDelete_GAP
            // 
            this.buttonDelete_GAP.BackColor = System.Drawing.Color.Sienna;
            this.buttonDelete_GAP.Location = new System.Drawing.Point(702, 16);
            this.buttonDelete_GAP.Name = "buttonDelete_GAP";
            this.buttonDelete_GAP.Size = new System.Drawing.Size(116, 56);
            this.buttonDelete_GAP.TabIndex = 5;
            this.buttonDelete_GAP.Text = "Удалить строку";
            this.buttonDelete_GAP.UseVisualStyleBackColor = false;
            this.buttonDelete_GAP.Click += new System.EventHandler(this.buttonDelete_GAP_Click);
            // 
            // labelSearch_GAP
            // 
            this.labelSearch_GAP.AutoSize = true;
            this.labelSearch_GAP.Location = new System.Drawing.Point(921, 18);
            this.labelSearch_GAP.Name = "labelSearch_GAP";
            this.labelSearch_GAP.Size = new System.Drawing.Size(48, 17);
            this.labelSearch_GAP.TabIndex = 4;
            this.labelSearch_GAP.Text = "Поиск";
            // 
            // textBoxSearch_GAP
            // 
            this.textBoxSearch_GAP.Location = new System.Drawing.Point(918, 53);
            this.textBoxSearch_GAP.Multiline = true;
            this.textBoxSearch_GAP.Name = "textBoxSearch_GAP";
            this.textBoxSearch_GAP.Size = new System.Drawing.Size(163, 22);
            this.textBoxSearch_GAP.TabIndex = 2;
            this.textBoxSearch_GAP.TextChanged += new System.EventHandler(this.textBoxSearch_GAP_TextChanged);
            // 
            // buttonInfo_GAP
            // 
            this.buttonInfo_GAP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInfo_GAP.Location = new System.Drawing.Point(9, 21);
            this.buttonInfo_GAP.Name = "buttonInfo_GAP";
            this.buttonInfo_GAP.Size = new System.Drawing.Size(71, 54);
            this.buttonInfo_GAP.TabIndex = 1;
            this.buttonInfo_GAP.UseVisualStyleBackColor = false;
            this.buttonInfo_GAP.Click += new System.EventHandler(this.buttonInfo_GAP_Click);
            // 
            // openFileDialog_GAP
            // 
            this.openFileDialog_GAP.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 599);
            this.Controls.Add(this.groupBox_GAP);
            this.Controls.Add(this.buttonOpen_GAP);
            this.Name = "FormMain";
            this.Text = "Общественный транспорт";
            this.groupBox_GAP.ResumeLayout(false);
            this.groupBox_GAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_GAP;
        private System.Windows.Forms.Button buttonOpen_GAP;
        private System.Windows.Forms.GroupBox groupBox_GAP;
        private System.Windows.Forms.Button buttonOp_GAP;
        private System.Windows.Forms.DataGridView dataGridView_GAP;
        private System.Windows.Forms.Button buttonAdd_GAP;
        private System.Windows.Forms.Button buttonSave_GAP;
        private System.Windows.Forms.Button buttonDelete_GAP;
        private System.Windows.Forms.Label labelSearch_GAP;
        private System.Windows.Forms.TextBox textBoxSearch_GAP;
        private System.Windows.Forms.OpenFileDialog openFileDialog_GAP;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_GAP;
        private System.Windows.Forms.Button buttonInfo_GAP;
    }
}
