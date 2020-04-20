using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {

        class List
        {
            public ulong L;//индексы
            public double value;//значение
            public List next = null;
        }

        class Matrix
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
                while(head != null)
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
        }


        static void insert(ref List arr, int i, int j, double _value, int N)
        {
            if (_value == 0) { delete(ref arr, i, j, N); return; }
            ulong L = Convert.ToUInt64(i + j * N);//конвертируем индексы
            List temp1 = arr, temp2 = null;
            while ((temp1 != null) && (L > temp1.L))
            {
                temp2 = temp1;
                temp1 = temp2.next;
            }
            if ((temp1 != null) && (L == temp1.L))//изменяем старое значение если нашли
            {
                temp1.value = _value;
            }
            else
            {
                List x = new List();//создаем элемент структуры под новый элемент
                x.L = L;
                x.value = _value;
                x.next = null;

                if (temp1 == null) temp2.next = x;//вставляем в конец
                else//вставляем между элементами или в начало
                {
                    if (temp2 == null) { x.next = temp1; arr = x; }
                    else { x.next = temp1; temp2.next = x; }
                }
            }
        }


        Matrix MultMatrux(Matrix m1, Matrix m2)
        {
            Matrix resMatrix = null;
            if (m1.N == m2.N)
            {
                List resElements = null;

                double res;
                int i, j, k;
                for(i = 0; i < m1.N; i++)
                {
                    for(j = 0; j < m1.N; j++)
                    {
                        //если в обоих векторах есть ненулевые значения
                        if(m1.RowIsNotZero(i) && m2.ColumnIsNotZero(j))
                        {
                            res = 0;
                            //перемножение векторов
                            for (k = 0; k < m1.N; k++)
                            {
                                List m1Elem = m1.Search(i, k);
                                List m2Elem = m2.Search(k, j);
                                if(m1Elem != null && m2Elem != null)
                                {
                                    res += m1Elem.value * m2Elem.value;
                                }
                            }

                            //добавление результата
                            if(res != 0)
                            {
                                insert(ref resElements, i, j, res, m1.N);
                            }
                        }
                    }
                }

                //создаем результирующую матрицу
                resMatrix = new Matrix();
                resMatrix.N = m1.N;
                resMatrix.elem = resElements;
            }
            else
            {
                //оповестить, что матрицы не могут быть разных размерностей
            }

            return resMatrix;
        }
    }
}
