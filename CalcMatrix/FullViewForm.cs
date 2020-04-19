using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CalcMatrix
{
    public partial class FullViewForm : Form
    {
        string current_opened_file = "1_1"; // имя текущего файла из которого берется матрица на экране
        string current_opened_matrix; //TODO
        string last_arrow; // последняя нажатая стрелка

        public FullViewForm()
        {
            InitializeComponent();
        }

        private string get_first_number() // возвращает первое число в имени текущего файла
        {
            string first_number = "";
            for (int i = 0; i < current_opened_file.Length; i++)
                if (current_opened_file[i] != '_')
                    first_number += current_opened_file[i];
                else break;
            return first_number;
        }

        private string get_second_number() // возвращает второе число в имени текущего файла
        {
            string second_number = "";
            for (int i = current_opened_file.Length - 1; i >= 0; i--)
                if (current_opened_file[i] != '_')
                    second_number = current_opened_file[i] + second_number;
                else break;
            return second_number;
        }

        private string first_number_plus() // 4 функции изменения чисел в имени файла
        {
            string first_number = get_first_number();
            string second_number = get_second_number();
            first_number = Convert.ToString(Convert.ToInt16(first_number) + 1);
            first_number = first_number + '_' + second_number;
            current_opened_file = first_number;
            return first_number;
        } 

        private string first_number_minus()
        {
            string first_number = get_first_number();
            string second_number = get_second_number();
            first_number = Convert.ToString(Convert.ToInt16(first_number) - 1);
            first_number = first_number + '_' + second_number;
            current_opened_file = first_number;
            return first_number;
        }

        private string second_number_plus()
        {
            string second_number = get_second_number();
            string first_number = get_first_number();
            second_number = Convert.ToString(Convert.ToInt16(second_number) + 1);
            second_number = first_number + '_' + second_number;
            current_opened_file = second_number;
            return second_number;
        }

        private string second_number_minus()
        {
            string second_number = get_second_number();
            string first_number = get_first_number();
            second_number = Convert.ToString(Convert.ToInt16(second_number) - 1);
            second_number = first_number + '_' + second_number;
            current_opened_file = second_number;
            return second_number;
        }

        private void RightArrow_Click(object sender, EventArgs e)//4 функции клика по стрелкам
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

        private void data_grid_draw(string matrix_name,string file_name) // функция отрисовки дата грида на форме
        {
            string file_path = "C:\\Users\\Кирилл\\Desktop\\CalcMatrix_git\\CalcMatrix\\matrix_"
                + matrix_name + "\\" + file_name + ".txt";
            try
            {
                using (StreamReader sw = new StreamReader(file_path))
                {
                    string line,temp_num = "";
                    int N_rows,N_columns;
                    int row_index = 0;

                    DataTable matrix = new DataTable("Матрица");
                    dataGridView1.Visible = false; //убираем дата грид на время обновления с экрана
                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();
                    dataGridView1.DataSource = matrix;

                    line = sw.ReadLine();
                    for (int i = 0; i< line.Length; i++) // считывание число строк
                        if (line[i] != ' ')
                            temp_num += line[i];
                        else break;
                    N_rows = Convert.ToInt16(temp_num); // число строк
                    temp_num = "";

                    for (int i = line.Length - 1; i >= 0; i--) // считывание числа столбцов
                        if (line[i] != ' ')
                            temp_num = line[i] + temp_num;
                        else break;
                    N_columns = Convert.ToInt16(temp_num); // число столбцов

                    for (int i = 0; i < N_columns; i++)
                        matrix.Columns.Add(Convert.ToString((Convert.ToInt16(get_second_number()) - 1) * 50 + i + 1));//Добавление столбцов на форму и выщитывание индекса

                    while ((line = sw.ReadLine()) != null) // чтение строк из файла и добавление на форму
                    {
                        string[] row_string = line.Split(new char[] { ' ' });//делим строку на массив чисел
                        matrix.Rows.Add(row_string); // добавляем строку в дата грид
                        dataGridView1.Update();
                        dataGridView1.Rows[row_index].HeaderCell.Value = ((Convert.ToInt16(get_first_number()) - 1) * 50 + row_index + 1).ToString(); //индекс строки
                        row_index++;
                    }
                }
                dataGridView1.Visible = true; //отображение дата грида после обновления
            }
            catch (FileNotFoundException)
            {
                if (current_opened_file == "1_1")
                    MessageBox.Show("Нарушена целостность файлов матрицы","Ошибка!");
                else
                    MessageBox.Show("Достигнут край матрицы");
                if (last_arrow == "right") //откат текущего имени файла при неудачной смене фокуса
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
