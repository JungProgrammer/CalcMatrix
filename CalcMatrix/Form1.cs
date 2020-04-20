using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace CalcMatrix
{

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InputFromFileForMatrix1_Click(object sender, EventArgs e) // ввод матрицы А из файла
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sw = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;
                        DataTable matrix = new DataTable("Матрица");
                        Matrix1ViewOnMainForm.DataSource = null;
                        Matrix1ViewOnMainForm.Rows.Clear();
                        Matrix1ViewOnMainForm.DataSource = matrix;
                        matrix.Columns.Add("Значение");
                        matrix.Columns.Add("Строка");
                        matrix.Columns.Add("Столбец");
                        while ((line = sw.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            string[] row_string = line.Split(new char[] { ' ' });//делим строку на массив чисел
                            matrix.Rows.Add(row_string); // добавляем строку в дата грид
                            Matrix1ViewOnMainForm.Update();
                        }
                    }

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void buttonFullViewMatrix1_Click(object sender, EventArgs e)
        {
            FullViewForm full_view = new FullViewForm("A");
            full_view.Show();
        }

        private void buttonFullViewMatrix2_Click(object sender, EventArgs e)
        {
            FullViewForm full_view = new FullViewForm("B");
            full_view.Show();
        }

        private void buttonFullViewMatrix3_Click(object sender, EventArgs e)
        {
            FullViewForm full_view = new FullViewForm("B");
            full_view.Show();
        }

        private void inputFromFileForMatrix2_Click(object sender, EventArgs e) // ввод матрицы B из файла
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sw = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;
                        DataTable matrix = new DataTable("Матрица");
                        Matrix2ViewOnMainForm.DataSource = null;
                        Matrix2ViewOnMainForm.Rows.Clear();
                        Matrix2ViewOnMainForm.DataSource = matrix;
                        matrix.Columns.Add("Значение");
                        matrix.Columns.Add("Строка");
                        matrix.Columns.Add("Столбец");
                        while ((line = sw.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            string[] row_string = line.Split(new char[] { ' ' });//делим строку на массив чисел
                            matrix.Rows.Add(row_string); // добавляем строку в дата грид
                            Matrix2ViewOnMainForm.Update();
                        }
                    }

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void SaveMatrix1ToFile_Click(object sender, EventArgs e) //сохранение в файл
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach(DataGridViewRow row in Matrix1ViewOnMainForm.Rows)
                    {
                        sw.Write(Convert.ToString(row.Cells[0].Value) + ' ' + Convert.ToString(row.Cells[1].Value) + ' ' + Convert.ToString(row.Cells[2].Value) + '\n');
                    }
                }
            }
        }

        private void SaveMatrix2ToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in Matrix2ViewOnMainForm.Rows)
                    {
                        sw.Write(Convert.ToString(row.Cells[0].Value) + ' ' + Convert.ToString(row.Cells[1].Value) + ' ' + Convert.ToString(row.Cells[2].Value) + '\n');
                    }
                }
            }
        }

        private void SaveResultMatrixToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (DataGridViewRow row in Matrix3ViewOnMainForm.Rows)
                    {
                        sw.Write(Convert.ToString(row.Cells[0].Value) + ' ' + Convert.ToString(row.Cells[1].Value) + ' ' + Convert.ToString(row.Cells[2].Value) + '\n');
                    }
                }
            }
        }
    }
}
