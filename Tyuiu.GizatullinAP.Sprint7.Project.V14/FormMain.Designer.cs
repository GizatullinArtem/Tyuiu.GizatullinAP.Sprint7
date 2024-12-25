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
            buttonHelp_GAP = new Button();
            buttonOpen_GAP = new Button();
            groupBox_GAP = new GroupBox();
            buttonOp_GAP = new Button();
            dataGridView_GAP = new DataGridView();
            buttonAdd_GAP = new Button();
            buttonSave_GAP = new Button();
            buttonDelete_GAP = new Button();
            labelSearch_GAP = new Label();
            textBoxSearch_GAP = new TextBox();
            buttonInfo_GAP = new Button();
            openFileDialog_GAP = new OpenFileDialog();
            saveFileDialog_GAP = new SaveFileDialog();
            groupBox_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_GAP).BeginInit();
            SuspendLayout();
            // 
            // buttonHelp_GAP
            // 
            buttonHelp_GAP.BackColor = SystemColors.ButtonFace;
            buttonHelp_GAP.Location = new Point(86, 20);
            buttonHelp_GAP.Name = "buttonHelp_GAP";
            buttonHelp_GAP.Size = new Size(59, 51);
            buttonHelp_GAP.TabIndex = 0;
            buttonHelp_GAP.Text = "Задание";
            buttonHelp_GAP.UseVisualStyleBackColor = false;
            buttonHelp_GAP.Click += buttonHelp_GAP_Click;
            // 
            // buttonOpen_GAP
            // 
            buttonOpen_GAP.Location = new Point(724, 278);
            buttonOpen_GAP.Name = "buttonOpen_GAP";
            buttonOpen_GAP.Size = new Size(66, 46);
            buttonOpen_GAP.TabIndex = 2;
            buttonOpen_GAP.Text = "Открыть";
            buttonOpen_GAP.UseVisualStyleBackColor = true;
            // 
            // groupBox_GAP
            // 
            groupBox_GAP.Controls.Add(buttonOp_GAP);
            groupBox_GAP.Controls.Add(dataGridView_GAP);
            groupBox_GAP.Controls.Add(buttonAdd_GAP);
            groupBox_GAP.Controls.Add(buttonSave_GAP);
            groupBox_GAP.Controls.Add(buttonDelete_GAP);
            groupBox_GAP.Controls.Add(labelSearch_GAP);
            groupBox_GAP.Controls.Add(textBoxSearch_GAP);
            groupBox_GAP.Controls.Add(buttonHelp_GAP);
            groupBox_GAP.Controls.Add(buttonInfo_GAP);
            groupBox_GAP.Location = new Point(10, 11);
            groupBox_GAP.Name = "groupBox_GAP";
            groupBox_GAP.Size = new Size(958, 539);
            groupBox_GAP.TabIndex = 3;
            groupBox_GAP.TabStop = false;
            groupBox_GAP.Text = "Задание";
            // 
            // buttonOp_GAP
            // 
            buttonOp_GAP.BackColor = SystemColors.ActiveCaption;
            buttonOp_GAP.Location = new Point(168, 20);
            buttonOp_GAP.Name = "buttonOp_GAP";
            buttonOp_GAP.Size = new Size(97, 52);
            buttonOp_GAP.TabIndex = 9;
            buttonOp_GAP.Text = "Открыть";
            buttonOp_GAP.UseVisualStyleBackColor = false;
            buttonOp_GAP.Click += button_Click;
            // 
            // dataGridView_GAP
            // 
            dataGridView_GAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_GAP.Location = new Point(8, 81);
            dataGridView_GAP.Name = "dataGridView_GAP";
            dataGridView_GAP.RowHeadersWidth = 51;
            dataGridView_GAP.RowTemplate.Height = 24;
            dataGridView_GAP.Size = new Size(790, 439);
            dataGridView_GAP.TabIndex = 8;
            // 
            // buttonAdd_GAP
            // 
            buttonAdd_GAP.BackColor = Color.Tan;
            buttonAdd_GAP.Location = new Point(490, 15);
            buttonAdd_GAP.Name = "buttonAdd_GAP";
            buttonAdd_GAP.Size = new Size(105, 52);
            buttonAdd_GAP.TabIndex = 7;
            buttonAdd_GAP.Text = "Добавить строку";
            buttonAdd_GAP.UseVisualStyleBackColor = false;
            buttonAdd_GAP.Click += buttonAdd_GAP_Click;
            // 
            // buttonSave_GAP
            // 
            buttonSave_GAP.BackColor = Color.Chocolate;
            buttonSave_GAP.Location = new Point(827, 442);
            buttonSave_GAP.Name = "buttonSave_GAP";
            buttonSave_GAP.Size = new Size(108, 66);
            buttonSave_GAP.TabIndex = 6;
            buttonSave_GAP.Text = "Сохранить";
            buttonSave_GAP.UseVisualStyleBackColor = false;
            buttonSave_GAP.Click += buttonSave_GAP_Click;
            // 
            // buttonDelete_GAP
            // 
            buttonDelete_GAP.BackColor = Color.Sienna;
            buttonDelete_GAP.Location = new Point(614, 15);
            buttonDelete_GAP.Name = "buttonDelete_GAP";
            buttonDelete_GAP.Size = new Size(102, 52);
            buttonDelete_GAP.TabIndex = 5;
            buttonDelete_GAP.Text = "Удалить строку";
            buttonDelete_GAP.UseVisualStyleBackColor = false;
            buttonDelete_GAP.Click += buttonDelete_GAP_Click;
            // 
            // labelSearch_GAP
            // 
            labelSearch_GAP.AutoSize = true;
            labelSearch_GAP.Location = new Point(806, 17);
            labelSearch_GAP.Name = "labelSearch_GAP";
            labelSearch_GAP.Size = new Size(42, 15);
            labelSearch_GAP.TabIndex = 4;
            labelSearch_GAP.Text = "Поиск";
            // 
            // textBoxSearch_GAP
            // 
            textBoxSearch_GAP.Location = new Point(803, 50);
            textBoxSearch_GAP.Multiline = true;
            textBoxSearch_GAP.Name = "textBoxSearch_GAP";
            textBoxSearch_GAP.Size = new Size(143, 21);
            textBoxSearch_GAP.TabIndex = 2;
            textBoxSearch_GAP.TextChanged += textBoxSearch_GAP_TextChanged;
            // 
            // buttonInfo_GAP
            // 
            buttonInfo_GAP.BackColor = SystemColors.ButtonFace;
            buttonInfo_GAP.Location = new Point(8, 20);
            buttonInfo_GAP.Name = "buttonInfo_GAP";
            buttonInfo_GAP.Size = new Size(62, 51);
            buttonInfo_GAP.TabIndex = 1;
            buttonInfo_GAP.Text = "Инфо";
            buttonInfo_GAP.UseVisualStyleBackColor = false;
            buttonInfo_GAP.Click += buttonInfo_GAP_Click;
            // 
            // openFileDialog_GAP
            // 
            openFileDialog_GAP.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 562);
            Controls.Add(groupBox_GAP);
            Controls.Add(buttonOpen_GAP);
            Name = "FormMain";
            Text = "Общественный транспорт";
            groupBox_GAP.ResumeLayout(false);
            groupBox_GAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_GAP).EndInit();
            ResumeLayout(false);
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
