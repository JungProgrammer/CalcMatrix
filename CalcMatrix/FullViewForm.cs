using System;
using System.Windows.Forms;

namespace CalcMatrix
{
    public partial class FullViewForm : Form
    {
        string current_opened_matrix; //текущая открытая матрица
        int current_row = 0; // начало текущего диапазона индексов строк
        int current_column = 0; // начало текущего диапазона индексов столбцов
        const int TABLE_DIM = 50; //Разрмерность матрицы data grid 
        int current_N; //размерность текущей матрицы
        mainForm.List current_head; // голова текущей матрицы
        public FullViewForm(string matr)
        {
            InitializeComponent();
            current_opened_matrix = matr;
        }

        private void RightArrow_Click(object sender, EventArgs e)//4 функции клика по стрелкам
        {
            if (current_column + TABLE_DIM < current_N)
            {
                current_column += 50;
                data_grid_draw();
            }
            else
                MessageBox.Show("Достигнут край матрицы", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            if (current_column >= TABLE_DIM)
            {
                current_column -= 50;
                data_grid_draw();
            }
            else
                MessageBox.Show("Достигнут край матрицы", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DownArrow_Click(object sender, EventArgs e)
        {
            if (current_row + TABLE_DIM < current_N)
            {
                current_row += 50;
                data_grid_draw();
            }
            else
                MessageBox.Show("Достигнут край матрицы", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UpArrow_Click(object sender, EventArgs e)
        {
            if (current_row >= TABLE_DIM)
            {
                current_row -= 50;
                data_grid_draw();
            }
            else
                MessageBox.Show("Достигнут край матрицы", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void data_grid_draw() // функция отрисовки дата грида на форме
        {
            dataGridView1.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            if (current_opened_matrix == "A") //определение какую матрицу показывать
            {
                current_N = mainForm.A_N;
                current_head = mainForm.head_A;
            }
            else if (current_opened_matrix == "B")
            {
                current_N = mainForm.B_N;
                current_head = mainForm.head_B;
            }
            else
            {
                current_N = mainForm.C_N;
                current_head = mainForm.head_C;
            }

            string[] row = new string[TABLE_DIM]; // добавление столбцов и подготовка массива нулей для заполнения строки
            for (int j = 0; j < TABLE_DIM ; j++)
            {
                row[j] = "0";
                dataGridView1.Columns.Add(Convert.ToString(current_column + j), Convert.ToString(current_column + j + 1));
            }

            for (int i = 0; i < TABLE_DIM; i++) 
            {
                dataGridView1.Rows.Add(row); // заполнение строки нулями
                dataGridView1.Rows[i].HeaderCell.Value = (current_row + i).ToString(); //индекс строки
            }
                for (int i = current_row; i < current_row + TABLE_DIM && i < current_N; i++) 
                    for (int j = current_column; j < current_column + TABLE_DIM && j < current_N; j++)
                        if (mainForm.search(current_head, i, j, current_N) != null) //пробегаем по всему списку и ищем значения, которе попадают в часть матрицы, которя на экране
                            dataGridView1.Rows[i%TABLE_DIM].Cells[j%TABLE_DIM].Value = mainForm.search(current_head, i, j, current_N).a; //если такое значение найдено, то заменяем 0 на это значение в data grid
                dataGridView1.Visible = true;
        }
        private void FullViewForm_Load(object sender, EventArgs e)
        {
            data_grid_draw();
        }
    }
}