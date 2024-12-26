using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.GizatullinAP.Sprint7.Project.V14.Lib;
using System.IO;
using Tyuiu.GizatullinAP.Sprint7.Project.V14;

namespace Tyuiu.GizatullinAP.Sprint7.Project.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonHelp_GAP_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog_GAP.ShowDialog();
                openFilePath = openFileDialog_GAP.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridView_GAP.RowCount = rows + 1;
                dataGridView_GAP.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView_GAP.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridView_GAP.AutoResizeColumns();
                dataGridView_GAP.ScrollBars = ScrollBars.Both;
                buttonSave_GAP.Enabled = true;
                buttonAdd_GAP.Enabled = true;
                buttonDelete_GAP.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_GAP_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_GAP.FileName = ".csv";
                saveFileDialog_GAP.InitialDirectory = @"C:\Sprint7";
                if (saveFileDialog_GAP.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_GAP.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridView_GAP.RowCount;
                    int columns = dataGridView_GAP.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridView_GAP.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_GAP_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_GAP.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_GAP_Click(object sender, EventArgs e)
        {
            if (dataGridView_GAP.RowCount != 0)
            {
                int valueDel = 0;
                var res = MessageBox.Show($"{"Удалить данную строку?"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) valueDel = 1;
                if (valueDel == 1)
                {
                    int del = dataGridView_GAP.CurrentCell.RowIndex;
                    dataGridView_GAP.Rows.Remove(dataGridView_GAP.Rows[del]);
                }
            }
            else
            {
                MessageBox.Show("Строка не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_GAP_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch_GAP.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView_GAP.Rows)
            {
                if (row.IsNewRow) continue;

                bool found = false;

                for (int j = 0; j < dataGridView_GAP.Columns.Count; j++)
                {
                    if (row.Cells[j].Value != null && row.Cells[j].Value.ToString().ToLower().Contains(searchValue))
                    {
                        found = true;
                        break;
                    }
                }

                row.Visible = found;
            }
        }

        private void buttonInfo_GAP_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }
    }
}





