using System;
using System.Windows.Forms;

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
    public int GetColumn(List elem)
    {
        return ((int)elem.L) / N;
    }

    /// <summary>
    /// Получает номер строки элемента
    /// </summary>
    /// <param name="elem"></param>
    /// <returns></returns>
    public int GetRow(List elem)
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
        ulong L = (ulong)(i + j * N);
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
        ulong L = (ulong)(i + j * N);


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
        ulong L = (ulong)(i + j * N);


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

    void Division(int i, double mult)//умножение строчки на число
    {
        List temp1;
        for (int j = 0; j < N; j++)
        {
            temp1 = Search(i, j);
            if (temp1 != null) temp1.value = temp1.value * mult;
        }
    }


    public List create_list(int i, int j, double a)
    {
        if (a == 0) return null;
        ulong L = (ulong)(i + j * N);

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

    /// <summary>
    /// Прибавляет к матрице вектор
    /// </summary>
    /// <param name="ded"></param>
    /// <param name="sub"></param>
    /// <param name="mult"></param>
    /// <param name="a"></param>
    /// <param name="N"></param>
    void Summ(int ded, int sub, double mult)//ded-слагаемое sub-то,с чем складывают
    {
        List temp1, temp2;
        for (int j = 0; j < N; j++)//проходимся по всей строчке
        {
            temp1 = Search(ded, j);//находим
            if (temp1 != null)//если нашли первую,то ищем вторую
            {
                temp2 = Search(sub, j);
                if (temp2 != null) { temp2.value = temp2.value + mult * temp1.value; if (temp2.value == 0) Delete(sub, j); }//Нашли?Складываем //если получился ноль,удаляем
                else
                    Insert(sub, j, mult * temp1.value); //Нет?Создаем новый элемент
            }
        }
    }

    /// <summary>
    /// Нахождение обратной матрицы
    /// </summary>
    /// <param name="arr"></param>
    /// <param name="N"></param>
    /// <returns></returns>
    public Matrix InverseMatrix()//обратная матрица методом Гаусса-Жордана
    {
        double vari;
        Matrix invMatrix = new Matrix();
        invMatrix.N = N;
        invMatrix.create_list(0, 0, 1); //создаем еденичную матрицу
        List temp, temp2;
        for (int i = 1; i < N; i++)
        {
            invMatrix.Insert(i, i, 1);

        }

        for (int j = 0; j < N; j++)             //обрабатываем каждый столбец
        {
            int i = j;
            temp = Search(i, j);        //ищем диагональный элемент
            while ((i < N) && (temp == null)) { i++; temp = Search(i, j); }//или ниже
            if (i == N) return null;//если не нашли,то у нее нет обратной матрицы
            if (i != j)//если нашли ниже диагональной-переносим на диагональную
            {
                Summ(i, j, 1);
                invMatrix.Summ(i, j, 1);
            }
            if (temp.value != 1)
            {//приводим к 1 диагональный элемент
                vari = temp.value;
                Division(j, 1.0 / vari);
                invMatrix.Division(j, 1.0 / vari);
            }

            for (i = 0; i < N; i++) //ищем остальные элементы в столбце
                if (i != j)//ОСТАЛЬНЫЕ!
                {
                    temp2 = Search(i, j);
                    if (temp2 != null) //Нашли?Нулим!
                    {
                        vari = temp2.value;
                        Summ(j, i, -vari);
                        invMatrix.Summ(j, i, -vari);
                    }
                }
        }
        return invMatrix;
    }
    public Matrix matr_summ(ref Matrix A,ref Matrix B)
    {
            List temp;
            Matrix C = new Matrix();
            C.N = A.N;
            temp = A.elem;
            while ((temp != null))
            {
                int temp_i = A.GetRow(temp);
                int temp_j = A.GetColumn(temp);
                if (C.Search(temp_i, temp_j) == null)
                    C.enter(temp_i, temp_j, temp.value);
                else
                    C.enter(temp_i, temp_j, temp.value + B.Search(temp_i, temp_j).value);
                temp = temp.next;
            }
            temp = B.elem;
            while ((temp != null))
            {
                int temp_i = B.GetRow(temp);
                int temp_j = B.GetColumn(temp);
                if (C.Search(temp_i, temp_j) == null)
                    C.enter(temp_i, temp_j, temp.value);
                else
                    C.enter(temp_i, temp_j, temp.value + A.Search(temp_i, temp_j).value);
                temp = temp.next;
            }
            return C;
    }

    public Matrix matr_minus(ref Matrix A, ref Matrix B)
    {
        List temp;
        Matrix C = new Matrix();
        C.N = A.N;
        temp = A.elem;
        while ((temp != null))
        {
            int temp_i = A.GetRow(temp);
            int temp_j = A.GetColumn(temp);
            if (B.Search(temp_i, temp_j) == null)
                C.enter(temp_i, temp_j, temp.value);
            else
                C.enter(temp_i, temp_j, temp.value - B.Search(temp_i, temp_j).value);
            temp = temp.next;
        }
        temp = B.elem;
        while ((temp != null))
        {
            int temp_i = B.GetRow(temp);
            int temp_j = B.GetColumn(temp);
            if (A.Search(temp_i, temp_j) == null)
                C.enter(temp_i, temp_j, -temp.value);
            else
                C.enter(temp_i, temp_j, temp.value + A.Search(temp_i, temp_j).value);
            temp = temp.next;
        }
        return C;
    }
    public Matrix MultMatrux(Matrix m1, Matrix m2)
    {
        Matrix resMatrix = null;
            resMatrix = new Matrix();
            resMatrix.N = m1.N;
            resMatrix.elem = new List();

            //переменная, куда будет считаться результат для двух векторов
            double res;
            int i, j, k;
            for (i = 0; i < m1.N; i++)
                for (j = 0; j < m1.N; j++)
                    //если в обоих векторах есть ненулевые значения
                    if (m1.RowIsNotZero(i) && m2.ColumnIsNotZero(j))
                    {
                        res = 0;
                        //перемножение векторов
                        for (k = 0; k < m1.N; k++)
                        {
                            List m1Elem = m1.Search(i, k);
                            List m2Elem = m2.Search(k, j);
                            if (m1Elem != null && m2Elem != null)
                            {
                                res += m1Elem.value * m2Elem.value;
                                res = Math.Round(res, 2);
                            }
                        }

                        //добавление результата
                        if (res != 0)
                            resMatrix.Insert(i, j, res);
                    }
        return resMatrix;
    }
}