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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonHelp_GAP = new Button();
            groupBox_GAP = new GroupBox();
            pictureSerch_GAP = new PictureBox();
            buttonOp_GAP = new Button();
            dataGridView_GAP = new DataGridView();
            buttonAdd_GAP = new Button();
            buttonSave_GAP = new Button();
            buttonDelete_GAP = new Button();
            textBoxSearch_GAP = new TextBox();
            buttonInfo_GAP = new Button();
            openFileDialog_GAP = new OpenFileDialog();
            saveFileDialog_GAP = new SaveFileDialog();
            toolTipInfo_GAP = new ToolTip(components);
            toolTip1 = new ToolTip(components);
            groupBox_GAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSerch_GAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_GAP).BeginInit();
            SuspendLayout();
            // 
            // buttonHelp_GAP
            // 
            buttonHelp_GAP.BackColor = SystemColors.ButtonFace;
            buttonHelp_GAP.Image = (Image)resources.GetObject("buttonHelp_GAP.Image");
            buttonHelp_GAP.Location = new Point(58, 22);
            buttonHelp_GAP.Name = "buttonHelp_GAP";
            buttonHelp_GAP.Size = new Size(41, 49);
            buttonHelp_GAP.TabIndex = 0;
            toolTip1.SetToolTip(buttonHelp_GAP, "Техническое задание");
            buttonHelp_GAP.UseVisualStyleBackColor = false;
            buttonHelp_GAP.Click += buttonHelp_GAP_Click;
            // 
            // groupBox_GAP
            // 
            groupBox_GAP.Controls.Add(pictureSerch_GAP);
            groupBox_GAP.Controls.Add(buttonOp_GAP);
            groupBox_GAP.Controls.Add(dataGridView_GAP);
            groupBox_GAP.Controls.Add(buttonAdd_GAP);
            groupBox_GAP.Controls.Add(buttonSave_GAP);
            groupBox_GAP.Controls.Add(buttonDelete_GAP);
            groupBox_GAP.Controls.Add(textBoxSearch_GAP);
            groupBox_GAP.Controls.Add(buttonHelp_GAP);
            groupBox_GAP.Controls.Add(buttonInfo_GAP);
            groupBox_GAP.Location = new Point(2, 12);
            groupBox_GAP.Name = "groupBox_GAP";
            groupBox_GAP.Size = new Size(734, 532);
            groupBox_GAP.TabIndex = 3;
            groupBox_GAP.TabStop = false;
            // 
            // pictureSerch_GAP
            // 
            pictureSerch_GAP.Image = (Image)resources.GetObject("pictureSerch_GAP.Image");
            pictureSerch_GAP.Location = new Point(401, 22);
            pictureSerch_GAP.Name = "pictureSerch_GAP";
            pictureSerch_GAP.Size = new Size(45, 49);
            pictureSerch_GAP.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureSerch_GAP.TabIndex = 10;
            pictureSerch_GAP.TabStop = false;
            // 
            // buttonOp_GAP
            // 
            buttonOp_GAP.BackColor = SystemColors.ButtonFace;
            buttonOp_GAP.Image = (Image)resources.GetObject("buttonOp_GAP.Image");
            buttonOp_GAP.Location = new Point(105, 22);
            buttonOp_GAP.Name = "buttonOp_GAP";
            buttonOp_GAP.Size = new Size(42, 49);
            buttonOp_GAP.TabIndex = 9;
            toolTip1.SetToolTip(buttonOp_GAP, "Открыть файл ");
            buttonOp_GAP.UseVisualStyleBackColor = false;
            buttonOp_GAP.Click += button_Click;
            // 
            // dataGridView_GAP
            // 
            dataGridView_GAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_GAP.Location = new Point(8, 75);
            dataGridView_GAP.Name = "dataGridView_GAP";
            dataGridView_GAP.RowHeadersWidth = 51;
            dataGridView_GAP.RowTemplate.Height = 24;
            dataGridView_GAP.Size = new Size(720, 439);
            dataGridView_GAP.TabIndex = 8;
            // 
            // buttonAdd_GAP
            // 
            buttonAdd_GAP.BackColor = SystemColors.ButtonFace;
            buttonAdd_GAP.Image = (Image)resources.GetObject("buttonAdd_GAP.Image");
            buttonAdd_GAP.Location = new Point(203, 22);
            buttonAdd_GAP.Name = "buttonAdd_GAP";
            buttonAdd_GAP.Size = new Size(43, 49);
            buttonAdd_GAP.TabIndex = 7;
            toolTip1.SetToolTip(buttonAdd_GAP, "Добавить строку");
            buttonAdd_GAP.UseVisualStyleBackColor = false;
            buttonAdd_GAP.Click += buttonAdd_GAP_Click;
            // 
            // buttonSave_GAP
            // 
            buttonSave_GAP.BackColor = SystemColors.ButtonFace;
            buttonSave_GAP.Image = (Image)resources.GetObject("buttonSave_GAP.Image");
            buttonSave_GAP.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave_GAP.Location = new Point(452, 22);
            buttonSave_GAP.Name = "buttonSave_GAP";
            buttonSave_GAP.Size = new Size(43, 49);
            buttonSave_GAP.TabIndex = 6;
            buttonSave_GAP.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(buttonSave_GAP, "Сохранить изменения");
            buttonSave_GAP.UseVisualStyleBackColor = false;
            buttonSave_GAP.Click += buttonSave_GAP_Click;
            // 
            // buttonDelete_GAP
            // 
            buttonDelete_GAP.BackColor = SystemColors.ButtonFace;
            buttonDelete_GAP.Image = (Image)resources.GetObject("buttonDelete_GAP.Image");
            buttonDelete_GAP.Location = new Point(153, 22);
            buttonDelete_GAP.Name = "buttonDelete_GAP";
            buttonDelete_GAP.Size = new Size(44, 49);
            buttonDelete_GAP.TabIndex = 5;
            toolTip1.SetToolTip(buttonDelete_GAP, "Удалить строку");
            buttonDelete_GAP.UseVisualStyleBackColor = false;
            buttonDelete_GAP.Click += buttonDelete_GAP_Click;
            // 
            // textBoxSearch_GAP
            // 
            textBoxSearch_GAP.Location = new Point(252, 22);
            textBoxSearch_GAP.Multiline = true;
            textBoxSearch_GAP.Name = "textBoxSearch_GAP";
            textBoxSearch_GAP.Size = new Size(143, 49);
            textBoxSearch_GAP.TabIndex = 2;
            textBoxSearch_GAP.TextChanged += textBoxSearch_GAP_TextChanged;
            // 
            // buttonInfo_GAP
            // 
            buttonInfo_GAP.BackColor = SystemColors.ButtonFace;
            buttonInfo_GAP.ForeColor = SystemColors.ActiveCaptionText;
            buttonInfo_GAP.Image = (Image)resources.GetObject("buttonInfo_GAP.Image");
            buttonInfo_GAP.Location = new Point(8, 22);
            buttonInfo_GAP.Name = "buttonInfo_GAP";
            buttonInfo_GAP.Size = new Size(44, 49);
            buttonInfo_GAP.TabIndex = 1;
            toolTipInfo_GAP.SetToolTip(buttonInfo_GAP, "Информация о разработчике");
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
            ClientSize = new Size(738, 556);
            Controls.Add(groupBox_GAP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormMain";
            Text = "Общественный транспорт";
            groupBox_GAP.ResumeLayout(false);
            groupBox_GAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSerch_GAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_GAP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button buttonHelp_GAP;
        private System.Windows.Forms.GroupBox groupBox_GAP;
        private System.Windows.Forms.Button buttonOp_GAP;
        private System.Windows.Forms.DataGridView dataGridView_GAP;
        private System.Windows.Forms.Button buttonAdd_GAP;
        private System.Windows.Forms.Button buttonSave_GAP;
        private System.Windows.Forms.Button buttonDelete_GAP;
        private System.Windows.Forms.TextBox textBoxSearch_GAP;
        private System.Windows.Forms.OpenFileDialog openFileDialog_GAP;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_GAP;
        private System.Windows.Forms.Button buttonInfo_GAP;
        private PictureBox pictureSerch_GAP;
        private ToolTip toolTipInfo_GAP;
        private ToolTip toolTip1;
    }
}
