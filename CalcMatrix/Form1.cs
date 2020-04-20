using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace CalcMatrix
{

    public partial class mainForm : Form
    {
        internal static List head_A;
        internal static List head_B;
        internal static List head_C;
        internal static int A_N;
        internal static int B_N;
        internal static int C_N; // TODO ДОБАВИТЬ ВЫСЧИТЫВАНИЕ РАЗМЕРНОСТИ К ОПЕРАЦИЯМ ИНАЧЕ ПИЗДА МОТОРУ


        internal class List
        {
            public ulong L;//индексы
            public double a;//значение
            public List next = null;
        }

        internal static List create_list(int i, int j, double a, int N)
        {
            if (a == 0) return null;
            ulong L = Convert.ToUInt64(i + j * N);//конвертируем индексы
            List arr = new List();
            arr.next = null;
            arr.a = a;
            arr.L = L;
            return arr;
        }
        internal static void insert(ref List arr, int i, int j, double a, int N)
        {
            if (a == 0) { delete(ref arr, i, j, N); return; }
            ulong L = Convert.ToUInt64(i + j * N);//конвертируем индексы
            List temp1 = arr, temp2 = null;
            while ((temp1 != null) && (L > temp1.L))
            {
                temp2 = temp1;
                temp1 = temp2.next;
            }
            if ((temp1 != null) && (L == temp1.L))//изменяем старое значение если нашли
            {
                temp1.a = a;
            }
            else
            {
                List x = new List();//создаем элемент структуры под новый элемент
                x.L = L;
                x.a = a;
                x.next = null;

                if (temp1 == null) temp2.next = x;//вставляем в конец
                else//вставляем между элементами или в начало
                {
                    if (temp2 == null) { x.next = temp1; arr = x; }
                    else { x.next = temp1; temp2.next = x; }
                }
            }
        }
        internal static List search(List arr, int i, int j, int N)
        {
            ulong L = Convert.ToUInt64(i + j * N);//конвертируем индексы
            List temp = arr;
            while ((temp != null) && (L != temp.L)) temp = temp.next;
            return temp;
        }

        internal static void delete(ref List arr, int i, int j, int N)
        {
            ulong L = Convert.ToUInt64(i + j * N);//конвертируем индексы
            List temp1 = arr, temp2 = null;
            while ((temp1 != null) && (L != temp1.L))
            {
                temp2 = temp1;
                temp1 = temp1.next;
            }
            if (temp1 != null)
            {//если нашли-удаляем
                if (temp2 != null)
                    temp2.next = temp1.next;
                else arr = arr.next;
            }
        }

        internal static void enter(ref List arr, int N, int i, int j, double a)
        {
            if (arr != null) insert(ref arr, i, j, a, N);
            else arr = create_list(i, j, a, N);
        }
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
                        A_N = Convert.ToInt32(sw.ReadLine()); // определение размерности
                        while ((line = sw.ReadLine()) != null)
                        {
                            string[] row_string = line.Split(new char[] { ' ' });//делим строку на массив чисел
                            enter(ref head_A, A_N, Convert.ToInt32(row_string[0]), Convert.ToInt32(row_string[1]), Convert.ToInt32(row_string[2])); //добавление в список
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
            FullViewForm full_view = new FullViewForm("A"); // просмотр матрицы А в полной форме
            full_view.Show();
        }

        private void buttonFullViewMatrix2_Click(object sender, EventArgs e)
        {
            FullViewForm full_view = new FullViewForm("B"); // просмотр матрицы B в полной форме
            full_view.Show();
        }

        private void buttonFullViewMatrix3_Click(object sender, EventArgs e)
        {
            FullViewForm full_view = new FullViewForm("C"); // просмотр матрицы C в полной форме
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
                        B_N = Convert.ToInt32(sw.ReadLine()); // определение размерности
                        while ((line = sw.ReadLine()) != null)
                        {
                            string[] row_string = line.Split(new char[] { ' ' });//делим строку на массив чисел
                            matrix.Rows.Add(row_string); // добавляем строку в дата грид
                            enter(ref head_B, B_N, Convert.ToInt32(row_string[0]), Convert.ToInt32(row_string[1]), Convert.ToInt32(row_string[2])); //добавление в список
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
                    sw.WriteLine(B_N);
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
                    sw.WriteLine(B_N);
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
                    sw.WriteLine(C_N);
                    foreach (DataGridViewRow row in ResultMatrixViewOnMainForm.Rows)
                        sw.Write(Convert.ToString(row.Cells[0].Value) + ' ' + Convert.ToString(row.Cells[1].Value) + ' ' + Convert.ToString(row.Cells[2].Value) + '\n');
                }
        }
    }
}