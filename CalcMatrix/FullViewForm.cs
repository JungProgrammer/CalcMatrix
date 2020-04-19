using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMatrix
{
    public partial class FullViewForm : Form
    {
        Graphics g;
        Pen myPen;
        SolidBrush br;            /*myPen = new Pen(Color.DeepSkyBlue, 1);
            br = new SolidBrush(Color.DeepSkyBlue);
            g = Graphics.FromHwnd(pictureBox1.Handle);

            g.DrawEllipse(myPen, 0, 0, 16, 16);
            g.FillEllipse(br, new Rectangle(0, 0, 16, 16));*/
        string current_opened_file = "1_1";
        string current_opened_matrix; //TODO
        string last_arrow;
        public FullViewForm()
        {
            InitializeComponent();
        }


        private string first_number_plus()
        {
            string new_opened_file = "";
            string old_part = "";
            for (int i = current_opened_file.Length - 1; i >= 0; i--)
                if (current_opened_file[i] != '_')
                    old_part = current_opened_file[i] + old_part;
                else break;
            for (int i = 0; i < current_opened_file.Length; i++)
                if (current_opened_file[i] != '_')
                    new_opened_file += current_opened_file[i];
                else break;
            new_opened_file = Convert.ToString(Convert.ToInt16(new_opened_file) + 1);
            new_opened_file = new_opened_file + '_' + old_part;
            current_opened_file = new_opened_file;
            return new_opened_file;
        }

        private string first_number_minus()
        {
            string new_opened_file = "";
            string old_part = "";
            for (int i = current_opened_file.Length - 1; i >= 0; i--)
                if (current_opened_file[i] != '_')
                    old_part = current_opened_file[i] + old_part;
                else break;
            for (int i = 0; i < current_opened_file.Length; i++)
                if (current_opened_file[i] != '_')
                    new_opened_file += current_opened_file[i];
                else break;
            new_opened_file = Convert.ToString(Convert.ToInt16(new_opened_file) - 1);
            new_opened_file =  new_opened_file + '_' + old_part;
            current_opened_file = new_opened_file;
            return new_opened_file;
        }

        private string second_number_plus()
        {
            string new_opened_file = "";
            string old_part = "";
            for (int i = current_opened_file.Length - 1; i >= 0; i--)
                if (current_opened_file[i] != '_')
                    new_opened_file = current_opened_file[i] + new_opened_file;
                else break;
            for (int i = 0; i < current_opened_file.Length; i++)
                if (current_opened_file[i] != '_')
                    old_part += current_opened_file[i];
                else break;
            new_opened_file = Convert.ToString(Convert.ToInt16(new_opened_file) + 1);
            new_opened_file = old_part + '_' + new_opened_file;
            current_opened_file = new_opened_file;
            return new_opened_file;
        }

        private string second_number_minus()
        {
            string new_opened_file = "";
            string old_part = "";
            for (int i = current_opened_file.Length - 1; i >= 0; i--)
                if (current_opened_file[i] != '_')
                    new_opened_file = current_opened_file[i] + new_opened_file;
                else break;
            for (int i = 0; i < current_opened_file.Length; i++)
                if (current_opened_file[i] != '_')
                    old_part += current_opened_file[i];
                else break;
            new_opened_file = Convert.ToString(Convert.ToInt16(new_opened_file) - 1);
            new_opened_file = old_part + '_' + new_opened_file;
            current_opened_file = new_opened_file;
            return new_opened_file;
        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            last_arrow = "right";
            data_grid_draw(current_opened_matrix = "A", second_number_plus());
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            last_arrow = "left";
            data_grid_draw(current_opened_matrix = "A", second_number_minus());
        }

        private void DownArrow_Click(object sender, EventArgs e)
        {
            last_arrow = "down";
            data_grid_draw(current_opened_matrix = "A",first_number_plus());
        }
        private void UpArrow_Click(object sender, EventArgs e)
        {
            last_arrow = "up";
            data_grid_draw(current_opened_matrix = "A", first_number_minus());
        }

        private void data_grid_draw(string matrix_name,string file_name)
        {
            string file_path = "C:\\Users\\Кирилл\\Desktop\\CalcMatrix\\CalcMatrix\\matrix_"
                + matrix_name + "\\" + file_name + ".txt";
            try
            {
                using (StreamReader sw = new StreamReader(file_path))
                {
                    string line,temp_num = "";
                    int N_rows,N_columns;
                    int row_index = 0;
                    DataTable matrix = new DataTable("Матрица");
                    dataGridView1.Visible = false;
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.DataSource = matrix;
                    line = sw.ReadLine();
                    for (int i = 0; i< line.Length; i++) // считывание число строк
                        if (line[i] != ' ')
                            temp_num += line[i];
                        else break;
                    N_rows = Convert.ToInt16(temp_num);
                    temp_num = "";
                    for (int i = line.Length - 1; i >= 0; i--) // считывание числа столбцов
                        if (line[i] != ' ')
                            temp_num = line[i] + temp_num;
                        else break;
                    N_columns = Convert.ToInt16(temp_num);
                    for (int i = 0; i < N_columns; i++)
                        matrix.Columns.Add(Convert.ToString(i + 1));//Добавление столбцов на форму
                    while ((line = sw.ReadLine()) != null) // чтение строк из файла и добавление на форму
                    {
                        string[] row_string = line.Split(new char[] { ' ' });
                        matrix.Rows.Add(row_string);
                        dataGridView1.Update();
                        dataGridView1.Rows[row_index].HeaderCell.Value = (row_index + 1).ToString();
                        row_index++;
                    }
                    matrix.WriteXml("a.xml", XmlWriteMode.WriteSchema);
                }
                dataGridView1.Visible = true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Достигнут край матрицы");
                if (last_arrow == "right")
                    second_number_minus();
                else if (last_arrow == "left")
                    second_number_plus();
                else if (last_arrow == "up")
                    first_number_plus();
                else if(last_arrow == "down")
                    first_number_minus();
            }
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        private void FullViewForm_Load(object sender, EventArgs e)
        {
            data_grid_draw("A", "1_1");
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
