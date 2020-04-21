using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace CalcMatrix
{

    public partial class mainForm : Form
    {
        Matrix A = new Matrix();
        Matrix B = new Matrix();
        Matrix C = new Matrix();

        //таблицы для ручного ввода матриц
        DataTable matrix1, matrix2;

        internal class List
        {
            public ulong L;//индексы
            public double value;//значение
            public List next = null;
        }

        internal class Matrix
        {
            public int N;
            public List elem;

            /// <summary>
            /// Получает номер столбца элемента
            /// </summary>
            /// <param name="elem"></param>
            /// <returns></returns>
            int GetColumn(List elem)
            {
                return ((int)elem.L) / N;
            }

            /// <summary>
            /// Получает номер строки элемента
            /// </summary>
            /// <param name="elem"></param>
            /// <returns></returns>
            int GetRow(List elem)
            {
                return (int)(elem.L - (ulong)GetColumn(elem) * (ulong)N);
            }

            /// <summary>
            /// Проверяет, есть ли ненулевые элементы в строке
            /// True - элемент найден
            /// False - элемент не найден
            /// </summary>
            /// <param name="row"></param>
            /// <returns></returns>
            public bool RowIsNotZero(int row)
            {
                bool isFind = false;

                List head = elem;
                while (head != null)
                {
                    //строка найдена
                    if (GetRow(head) == row) isFind = true;
                    head = head.next;
                }

                return isFind;
            }

            /// <summary>
            /// Проверяет, есть ли ненулевые элементы в столбце
            /// True - элемент найден
            /// False - элемент не найден
            /// </summary>
            /// <param name="row"></param>
            /// <returns></returns>
            public bool ColumnIsNotZero(int column)
            {
                bool isFind = false;

                List head = elem;
                while (head != null)
                {
                    //строка найдена
                    if (GetColumn(head) == column) isFind = true;
                    head = head.next;
                }

                return isFind;
            }

            /// <summary>
            /// Производит поиск элемента по заданным индексам
            /// </summary>
            /// <param name="arr"></param>
            /// <param name="i"></param>
            /// <param name="j"></param>
            /// <param name="N"></param>
            /// <returns></returns>
            public List Search(int i, int j)
            {
                ulong L = Convert.ToUInt64(i + j * N);
                List temp = this.elem;
                while ((temp != null) && (L != temp.L)) temp = temp.next;
                return temp;
            }

            /// <summary>
            /// Удаление элемента в матрице
            /// </summary>
            /// <param name="arr"></param>
            /// <param name="i"></param>
            /// <param name="j"></param>
            /// <param name="N"></param>
            public void Delete(int i, int j)
            {
                //конвертируем индексы
                ulong L = Convert.ToUInt64(i + j * N);

                List temp1 = elem, temp2 = null;
                while ((temp1 != null) && (L != temp1.L))
                {
                    temp2 = temp1;
                    temp1 = temp1.next;
                }
                if (temp1 != null)
                {
                    //если нашли-удаляем
                    if (temp2 != null)
                        temp2.next = temp1.next;
                    else elem = elem.next;
                }
            }

            /// <summary>
            /// Вставка элемента в матрицу
            /// </summary>
            /// <param name="arr"></param>
            /// <param name="i"></param>
            /// <param name="j"></param>
            /// <param name="_value"></param>
            /// <param name="N"></param>
            public void Insert(int i, int j, double _value)
            {
                if (_value == 0)
                {
                    Delete(i, j); return;
                }

                //конвертируем индексы
                ulong L = Convert.ToUInt64(i + j * N);

                List temp1 = elem, temp2 = null;
                while ((temp1 != null) && (L > temp1.L))
                {
                    temp2 = temp1;
                    temp1 = temp2.next;
                }
                //изменяем старое значение если нашли
                if ((temp1 != null) && (L == temp1.L))
                {
                    temp1.value = _value;
                }
                else
                {
                    //создаем элемент структуры под новый элемент
                    List x = new List();
                    x.L = L;
                    x.value = _value;
                    x.next = null;

                    //вставляем в конец
                    if (temp1 == null) temp2.next = x;
                    else//вставляем между элементами или в начало
                    {
                        if (temp2 == null) { x.next = temp1; elem = x; }
                        else { x.next = temp1; temp2.next = x; }
                    }
                }
            }
            public List create_list(int i, int j, double a)
            {
                if (a == 0) return null;
                ulong L = Convert.ToUInt64(i + j * N);//конвертируем индексы
                elem = new List();
                elem.next = null;
                elem.value = a;
                elem.L = L;
                return elem;
            }

            public void enter(int i, int j, double a)
            {
                if (elem != null) Insert(i, j, a);
                else elem = create_list(i, j, a);
            }
        }

        public mainForm()
        {
            InitializeComponent();
            InitFormsForInputsMatrix();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void InputFromFileForMatrix1_Click(object sender, EventArgs e) // ввод матрицы А из файла
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    using (StreamReader sw = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;
                        DataTable matrix = new DataTable("Матрица");
                        Matrix1ViewOnMainForm.DataSource = null;
                        Matrix1ViewOnMainForm.Rows.Clear();
                        Matrix1ViewOnMainForm.DataSource = matrix;
                        matrix.Columns.Add("Строка");
                        matrix.Columns.Add("Столбец");
                        matrix.Columns.Add("Значение");
                        A.N = Convert.ToInt32(sw.ReadLine()); // определение размерности
                        while ((line = sw.ReadLine()) != null)
                        {
                            string[] row_string = line.Split(new char[] { ' ' });//делим строку на массив чисел
                            A.enter(Convert.ToInt32(row_string[0]), Convert.ToInt32(row_string[1]), Convert.ToInt32(row_string[2]));
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {
                    using (StreamReader sw = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;
                        DataTable matrix = new DataTable("Матрица");
                        Matrix2ViewOnMainForm.DataSource = null;
                        Matrix2ViewOnMainForm.Rows.Clear();
                        Matrix2ViewOnMainForm.DataSource = matrix;
                        matrix.Columns.Add("Строка");
                        matrix.Columns.Add("Столбец");
                        matrix.Columns.Add("Значение");
                        B.N = Convert.ToInt32(sw.ReadLine()); // определение размерности
                        while ((line = sw.ReadLine()) != null)
                        {
                            string[] row_string = line.Split(new char[] { ' ' });//делим строку на массив чисел
                            matrix.Rows.Add(row_string); // добавляем строку в дата грид
                            B.enter(Convert.ToInt32(row_string[0]), Convert.ToInt32(row_string[1]), Convert.ToInt32(row_string[2]));
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

        private void SaveMatrix1ToFile_Click(object sender, EventArgs e) //сохранение матрицы А в файл
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // маска для подсказывания пользователю, какое расширение нужно выбрать при сохранении файла
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(A.N);
                    foreach(DataGridViewRow row in Matrix1ViewOnMainForm.Rows)
                        sw.Write(Convert.ToString(row.Cells[0].Value) + ' ' + Convert.ToString(row.Cells[1].Value) + ' ' + Convert.ToString(row.Cells[2].Value) + '\n');
                }
        }

        private void SaveMatrix2ToFile_Click(object sender, EventArgs e) //сохранение матрицы В в файл
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // маска для подсказывания пользователю, какое расширение нужно выбрать при сохранении файла
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(B.N);
                    foreach (DataGridViewRow row in Matrix2ViewOnMainForm.Rows)
                        sw.Write(Convert.ToString(row.Cells[0].Value) + ' ' + Convert.ToString(row.Cells[1].Value) + ' ' + Convert.ToString(row.Cells[2].Value) + '\n');
                }
        }

        private void SaveResultMatrixToFile_Click(object sender, EventArgs e) //сохранение матрицы С в файл
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // маска для подсказывания пользователю, какое расширение нужно выбрать при сохранении файла
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine(C.N);
                    foreach (DataGridViewRow row in ResultMatrixViewOnMainForm.Rows)
                        sw.Write(Convert.ToString(row.Cells[0].Value) + ' ' + Convert.ToString(row.Cells[1].Value) + ' ' + Convert.ToString(row.Cells[2].Value) + '\n');
                }
        }

        /// <summary>
        /// Инициализация таблиц матриц на главной форме
        /// </summary>
        void InitFormsForInputsMatrix()
        {
            matrix1 = new DataTable();
            matrix1.Columns.Add("Строка");
            matrix1.Columns.Add("Столбец");
            matrix1.Columns.Add("Значение");
            Matrix1ViewOnMainForm.DataSource = null;
            Matrix1ViewOnMainForm.Rows.Clear();
            Matrix1ViewOnMainForm.DataSource = matrix1;

            matrix2 = new DataTable();
            matrix2.Columns.Add("Строка");
            matrix2.Columns.Add("Столбец");
            matrix2.Columns.Add("Значение");
            Matrix2ViewOnMainForm.DataSource = null;
            Matrix2ViewOnMainForm.Rows.Clear();
            Matrix2ViewOnMainForm.DataSource = matrix2;
        }

        //Клик на OK в первой матрице
        private void Button1_Click(object sender, EventArgs e)
        {
            double val;
            int i, j;
            try
            {
                val = Convert.ToDouble(inputValueForFirstMatrix1OnMainForm.Text);
                i = Convert.ToInt32(inputRowForFirstMatrix1OnMainForm.Text);
                j = Convert.ToInt32(inputColumnForFirstMatrix1OnMainForm.Text);

                A.enter(i, j, val);

                // добавляем строку в дата грид
                matrix1.Rows.Add(i, j, val);
                Matrix1ViewOnMainForm.Update();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод!");
            }

        }

        //Клик на ОК на второй матрице
        private void Button2_Click(object sender, EventArgs e)
        {
            double val;
            int i, j;
            try
            {
                val = Convert.ToDouble(inputValueForFirstMatrix2OnMainForm.Text);
                i = Convert.ToInt32(inputRowForFirstMatrix2OnMainForm.Text);
                j = Convert.ToInt32(inputColumnForFirstMatrix2OnMainForm.Text);

                B.enter(i, j, val);

                // добавляем строку в дата грид
                matrix2.Rows.Add(i, j, val);
                Matrix2ViewOnMainForm.Update();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод!");
            }
        }
    }
}