using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace CalcMatrix
{

    public partial class mainForm : Form
    {
        Matrix A;
        Matrix B;
        Matrix C;
        DataTable matrix1, matrix2, matrix3;

        public mainForm()
        {
            InitializeComponent();
            InitFormsForInputsMatrix();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        void InitFormsForInputsMatrix() // инициализация матриц
        {
            A = new Matrix();
            matrix1 = new DataTable();
            matrix1.Columns.Add("Строка");
            matrix1.Columns.Add("Столбец");
            matrix1.Columns.Add("Значение");
            Matrix1ViewOnMainForm.DataSource = null;
            Matrix1ViewOnMainForm.Rows.Clear();
            Matrix1ViewOnMainForm.DataSource = matrix1;

            B = new Matrix();
            matrix2 = new DataTable();
            matrix2.Columns.Add("Строка");
            matrix2.Columns.Add("Столбец");
            matrix2.Columns.Add("Значение");
            Matrix2ViewOnMainForm.DataSource = null;
            Matrix2ViewOnMainForm.Rows.Clear();
            Matrix2ViewOnMainForm.DataSource = matrix2;

            C = new Matrix();
            matrix3 = new DataTable();
            matrix3.Columns.Add("Строка");
            matrix3.Columns.Add("Столбец");
            matrix3.Columns.Add("Значение");
            ResultMatrixViewOnMainForm.DataSource = null;
            ResultMatrixViewOnMainForm.Rows.Clear();
            ResultMatrixViewOnMainForm.DataSource = matrix3;
        }

        void show_result() // отображение результата операции
        {
            ResultMatrixViewOnMainForm.DataSource = null;
            ResultMatrixViewOnMainForm.Rows.Clear();
            ResultMatrixViewOnMainForm.DataSource = matrix3;
            List temp = C.elem;
            while ((temp != null))
            {
                string[] row_string = new string[3];
                row_string[0] = C.GetRow(temp).ToString();
                row_string[1] = C.GetColumn(temp).ToString();
                row_string[2] = temp.value.ToString();
                matrix3.Rows.Add(row_string); // добавляем строку в дата грид
                ResultMatrixViewOnMainForm.Update();
                temp = temp.next;
            }
        }

        private void file_save(DataGridView grid, Matrix mt) // сохранение в файл
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // маска для подсказывания пользователю, какое расширение нужно выбрать при сохранении файла
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(mt.N); //вывод размерности
                    foreach (DataGridViewRow row in grid.Rows) //вывод элементов
                        sw.Write(Convert.ToString(row.Cells[0].Value) + ' ' + Convert.ToString(row.Cells[1].Value) + ' ' + Convert.ToString(row.Cells[2].Value) + '\n');
                }
        }

        private void file_input(ref DataGridView grid, ref Matrix mt) // ввод из файла
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    using (StreamReader sw = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;
                        grid.DataSource = null;
                        grid.Rows.Clear();
                        grid.DataSource = matrix1;
                        mt = new Matrix();
                        mt.N = Convert.ToInt32(sw.ReadLine()); // определение размерности
                        while ((line = sw.ReadLine()) != null)
                        {
                            string[] row_string = line.Split(new char[] { ' ' });//делим строку на массив чисел
                            mt.enter(Convert.ToInt32(row_string[0]), Convert.ToInt32(row_string[1]), Convert.ToDouble(row_string[2]));
                            matrix1.Rows.Add(row_string); // добавляем строку в дата грид
                            grid.Update();
                        }
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
        }



        private void random_fill(ref DataGridView grid, ref Matrix mt, ref DataTable dt, ref TextBox setNforMatrix)
        {

            int elem_numbers;//количество случайных чисел
            int i_rand, j_rand; // случайные индексы
            Random r = new Random();
            grid.DataSource = null;
            grid.Rows.Clear();
            dt.Rows.Clear();
            grid.DataSource = dt;
            mt = new Matrix();
            mt.N = Convert.ToInt32(setNforMatrix.Text);
            if (mt.N >= 1 && mt.N <= 100000) // проверка правильности размерности 
            {
                elem_numbers = r.Next(mt.N - mt.N / 10, mt.N + mt.N / 10); //Генерация количества случайных чисел в пределах N+-10% От N
                for (int i = 0; i < elem_numbers; i++)
                {
                    double elem = r.Next(-100001, 100000); // генерация целой части
                    int elem_float = r.Next(0, 99); // генерация дробной части
                    elem += elem_float / 100.0; // объединение целой и дробной
                    do
                    {
                        i_rand = r.Next(0, mt.N); // генерация случайных индексов
                        j_rand = r.Next(0, mt.N);
                        if (mt.Search(i_rand, j_rand) == null) //если элемента с такими индексами нет, то вставляем
                        {
                            mt.enter(i_rand, j_rand, elem);
                            string[] row_string = new string[3];
                            row_string[0] = i_rand.ToString();
                            row_string[1] = j_rand.ToString();
                            row_string[2] = elem.ToString();
                            dt.Rows.Add(row_string); // добавляем строку в дата грид
                            grid.Update();
                        }
                    } while (mt.Search(i_rand, j_rand) == null); // генерируем рандомные индексы пока натыкаемся на существующие элементы
                }
            }
            else
                MessageBox.Show("Некорректная размерность матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InputFromFileForMatrix1_Click(object sender, EventArgs e) // ввод матрицы А из файла
        {
            file_input(ref Matrix1ViewOnMainForm, ref A);
        }

        private void buttonFullViewMatrix1_Click(object sender, EventArgs e)
        {
            FullViewForm full_view = new FullViewForm(A); // просмотр матрицы А в полной форме
            full_view.Show();
        }

        private void buttonFullViewMatrix2_Click(object sender, EventArgs e)
        {
            FullViewForm full_view = new FullViewForm(B); // просмотр матрицы B в полной форме
            full_view.Show();
        }

        private void buttonFullViewMatrix3_Click(object sender, EventArgs e)
        {
            FullViewForm full_view = new FullViewForm(C); // просмотр матрицы C в полной форме
            full_view.Show();
        }

        private void inputFromFileForMatrix2_Click(object sender, EventArgs e) // ввод матрицы B из файла
        {
            file_input(ref Matrix2ViewOnMainForm, ref B);
        }

        private void SaveMatrix1ToFile_Click(object sender, EventArgs e) //сохранение матрицы А в файл
        {
            file_save(Matrix1ViewOnMainForm, A);
        }

        private void SaveMatrix2ToFile_Click(object sender, EventArgs e) //сохранение матрицы В в файл
        {
            file_save(Matrix2ViewOnMainForm, B);
        }

        private void SaveResultMatrixToFile_Click(object sender, EventArgs e) //сохранение матрицы С в файл
        {
            file_save(ResultMatrixViewOnMainForm, C);
        }

        private void inputRandomNumsForMatrix1_Click(object sender, EventArgs e)
        {
            random_fill(ref Matrix1ViewOnMainForm, ref A, ref matrix1, ref setNForMatrix1);
        }

        private void setNForMatrix1_KeyPress(object sender, KeyPressEventArgs e) // ограничение ввода размерности
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void setNForMatrix2_KeyPress(object sender, KeyPressEventArgs e) // ограничение ввода размерности
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
                e.Handled = true;
        }

        private void inputRandomNumsForMatrix2_Click(object sender, EventArgs e)
        {
            random_fill(ref Matrix2ViewOnMainForm, ref B, ref matrix2, ref setNForMatrix2);
        }

        private void SumBut_Click(object sender, EventArgs e)
        {
            matrix3.Rows.Clear();
            C.N = A.N;
            C = A.Matr_summ_kir(ref A, ref B);
            show_result();
        }

        private void Dev_Click(object sender, EventArgs e)
        {
            matrix3.Rows.Clear();
            C.N = A.N;
            C = A.Matr_minus_kir(ref A, ref B);
            show_result();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            C.N = A.N;
            C = C.InverseMatrix();
            matrix3.Rows.Clear();
            show_result();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (setNForMatrix1.Text != "")
            {
                A.N = Convert.ToInt32(setNForMatrix1.Text);
                if (A.N >= 1 && A.N <= 100000) // проверка правильности размерности 
                {
                    double val;
                    int i, j;
                    try
                    {
                        val = Convert.ToDouble(inputValueForFirstMatrix1OnMainForm.Text);
                        i = Convert.ToInt32(inputRowForFirstMatrix1OnMainForm.Text);
                        j = Convert.ToInt32(inputColumnForFirstMatrix1OnMainForm.Text);
                        if (i <= A.N && j <= A.N)
                        {

                            A.enter(i, j, val);

                            //переменная для поиска элемента в таблице
                            bool isFind = false;
                            //если у нас в таблице уже есть элементы
                            if (matrix1.Rows.Count > 0)
                            {
                                //проходим по строкам таблицы
                                for (int k = 0; k < matrix1.Rows.Count; k++)
                                {
                                    //если у нас совпали координаты с координатами в строке таблицы
                                    if (i == Convert.ToInt32(matrix1.Rows[k]["Строка"]) && j == Convert.ToInt32(matrix1.Rows[k]["Столбец"]))
                                    {
                                        //обновляем элемент в таблице
                                        isFind = true;
                                        matrix1.Rows[k].BeginEdit();
                                        matrix1.Rows[k]["Значение"] = val;
                                        matrix1.Rows[k]["Строка"] = i;
                                        matrix1.Rows[k]["Столбец"] = j;
                                        matrix1.Rows[k].EndEdit();
                                    }
                                }
                                //если такого элемента не было в таблице, то добавляем новый
                                if (!isFind)
                                {
                                    // добавляем строку в дата грид
                                    matrix1.Rows.Add(i, j, val);
                                    Matrix1ViewOnMainForm.Update();
                                }
                            }
                            //если таблица пустая
                            else
                            {
                                // добавляем строку в дата грид
                                matrix1.Rows.Add(i, j, val);
                                Matrix1ViewOnMainForm.Update();
                            }
                        } else
                            MessageBox.Show("Индекс больше размерности матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("Некорректный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Некорректная размерность матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Некорректная размерность матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (setNForMatrix2.Text != "")
            {
                B.N = Convert.ToInt32(setNForMatrix2.Text);
                if (B.N >= 1 && B.N <= 100000) // проверка правильности размерности 
                {
                    double val;
                    int i, j;
                    try
                    {
                        val = Convert.ToDouble(inputValueForFirstMatrix2OnMainForm.Text);
                        i = Convert.ToInt32(inputRowForFirstMatrix2OnMainForm.Text);
                        j = Convert.ToInt32(inputColumnForFirstMatrix2OnMainForm.Text);
                        if (i <= B.N && j <= B.N)
                        {
                            B.enter(i, j, val);

                            //переменная для поиска элемента в таблице
                            bool isFind = false;
                            //если у нас в таблице уже есть элементы
                            if (matrix2.Rows.Count > 0)
                            {
                                //проходим по строкам таблицы
                                for (int k = 0; k < matrix2.Rows.Count; k++)
                                {
                                    //если у нас совпали координаты с координатами в строке таблицы
                                    if (i == Convert.ToInt32(matrix2.Rows[k]["Строка"]) && j == Convert.ToInt32(matrix2.Rows[k]["Столбец"]))
                                    {
                                        //обновляем элемент в таблице
                                        isFind = true;
                                        matrix2.Rows[k].BeginEdit();
                                        matrix2.Rows[k]["Значение"] = val;
                                        matrix2.Rows[k]["Строка"] = i;
                                        matrix2.Rows[k]["Столбец"] = j;
                                        matrix2.Rows[k].EndEdit();
                                    }
                                }
                                //если такого элемента не было в таблице, то добавляем новый
                                if (!isFind)
                                {
                                    // добавляем строку в дата грид
                                    matrix2.Rows.Add(i, j, val);
                                    Matrix2ViewOnMainForm.Update();
                                }

                            }
                            //если таблица пустая
                            else
                            {
                                // добавляем строку в дата грид
                                matrix2.Rows.Add(i, j, val);
                                Matrix2ViewOnMainForm.Update();
                            }
                        } else
                            MessageBox.Show("Индекс больше размерности матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    catch
                    {
                        MessageBox.Show("Некорректный ввод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                    MessageBox.Show("Некорректная размерность матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
                MessageBox.Show("Некорректная размерность матрицы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}