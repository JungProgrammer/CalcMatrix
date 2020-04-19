namespace CalcMatrix
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Matrix1ViewOnMainForm = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.inputValueForFirstMatrix1OnMainForm = new System.Windows.Forms.TextBox();
            this.inputRowForFirstMatrix1OnMainForm = new System.Windows.Forms.TextBox();
            this.inputColumnForFirstMatrix1OnMainForm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputColumnForFirstMatrix2OnMainForm = new System.Windows.Forms.TextBox();
            this.inputRowForFirstMatrix2OnMainForm = new System.Windows.Forms.TextBox();
            this.inputValueForFirstMatrix2OnMainForm = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.setNForMatrix1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.setNForMatrix2 = new System.Windows.Forms.TextBox();
            this.inputRandomNumsForMatrix1 = new System.Windows.Forms.Button();
            this.inputFromFileForMatrix1 = new System.Windows.Forms.Button();
            this.inputRandomNumsForMatrix2 = new System.Windows.Forms.Button();
            this.inputFromFileForMatrix2 = new System.Windows.Forms.Button();
            this.buttonFullViewMatrix1 = new System.Windows.Forms.Button();
            this.buttonFullViewMatrix2 = new System.Windows.Forms.Button();
            this.SumBut = new System.Windows.Forms.Button();
            this.Dev = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonFullViewMatrix3 = new System.Windows.Forms.Button();
            this.SaveMatrix1ToFile = new System.Windows.Forms.Button();
            this.SaveMatrix2ToFile = new System.Windows.Forms.Button();
            this.SaveResultMatrixToFile = new System.Windows.Forms.Button();
            this.Matrix2ViewOnMainForm = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultMatrixViewOnMainForm = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix1ViewOnMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix2ViewOnMainForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrixViewOnMainForm)).BeginInit();
            this.SuspendLayout();
            // 
            // Matrix1ViewOnMainForm
            // 
            this.Matrix1ViewOnMainForm.AllowUserToDeleteRows = false;
            this.Matrix1ViewOnMainForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Matrix1ViewOnMainForm.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Matrix1ViewOnMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix1ViewOnMainForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value,
            this.Row,
            this.Column});
            this.Matrix1ViewOnMainForm.Location = new System.Drawing.Point(30, 160);
            this.Matrix1ViewOnMainForm.Name = "Matrix1ViewOnMainForm";
            this.Matrix1ViewOnMainForm.Size = new System.Drawing.Size(279, 333);
            this.Matrix1ViewOnMainForm.TabIndex = 0;
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            // 
            // Row
            // 
            this.Row.HeaderText = "Строка";
            this.Row.Name = "Row";
            // 
            // Column
            // 
            this.Column.HeaderText = "Столбец";
            this.Column.Name = "Column";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(315, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // inputValueForFirstMatrix1OnMainForm
            // 
            this.inputValueForFirstMatrix1OnMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputValueForFirstMatrix1OnMainForm.Location = new System.Drawing.Point(30, 128);
            this.inputValueForFirstMatrix1OnMainForm.Name = "inputValueForFirstMatrix1OnMainForm";
            this.inputValueForFirstMatrix1OnMainForm.Size = new System.Drawing.Size(89, 26);
            this.inputValueForFirstMatrix1OnMainForm.TabIndex = 3;
            // 
            // inputRowForFirstMatrix1OnMainForm
            // 
            this.inputRowForFirstMatrix1OnMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRowForFirstMatrix1OnMainForm.Location = new System.Drawing.Point(125, 128);
            this.inputRowForFirstMatrix1OnMainForm.Name = "inputRowForFirstMatrix1OnMainForm";
            this.inputRowForFirstMatrix1OnMainForm.Size = new System.Drawing.Size(89, 26);
            this.inputRowForFirstMatrix1OnMainForm.TabIndex = 4;
            // 
            // inputColumnForFirstMatrix1OnMainForm
            // 
            this.inputColumnForFirstMatrix1OnMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputColumnForFirstMatrix1OnMainForm.Location = new System.Drawing.Point(220, 128);
            this.inputColumnForFirstMatrix1OnMainForm.Name = "inputColumnForFirstMatrix1OnMainForm";
            this.inputColumnForFirstMatrix1OnMainForm.Size = new System.Drawing.Size(89, 26);
            this.inputColumnForFirstMatrix1OnMainForm.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(124, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Строка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(216, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Столбец";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(897, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Столбец";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(805, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Строка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(708, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Значение";
            // 
            // inputColumnForFirstMatrix2OnMainForm
            // 
            this.inputColumnForFirstMatrix2OnMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputColumnForFirstMatrix2OnMainForm.Location = new System.Drawing.Point(901, 128);
            this.inputColumnForFirstMatrix2OnMainForm.Name = "inputColumnForFirstMatrix2OnMainForm";
            this.inputColumnForFirstMatrix2OnMainForm.Size = new System.Drawing.Size(89, 26);
            this.inputColumnForFirstMatrix2OnMainForm.TabIndex = 12;
            // 
            // inputRowForFirstMatrix2OnMainForm
            // 
            this.inputRowForFirstMatrix2OnMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRowForFirstMatrix2OnMainForm.Location = new System.Drawing.Point(806, 128);
            this.inputRowForFirstMatrix2OnMainForm.Name = "inputRowForFirstMatrix2OnMainForm";
            this.inputRowForFirstMatrix2OnMainForm.Size = new System.Drawing.Size(89, 26);
            this.inputRowForFirstMatrix2OnMainForm.TabIndex = 11;
            // 
            // inputValueForFirstMatrix2OnMainForm
            // 
            this.inputValueForFirstMatrix2OnMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputValueForFirstMatrix2OnMainForm.Location = new System.Drawing.Point(711, 128);
            this.inputValueForFirstMatrix2OnMainForm.Name = "inputValueForFirstMatrix2OnMainForm";
            this.inputValueForFirstMatrix2OnMainForm.Size = new System.Drawing.Size(89, 26);
            this.inputValueForFirstMatrix2OnMainForm.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(996, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ок";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(26, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Размерность";
            // 
            // setNForMatrix1
            // 
            this.setNForMatrix1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setNForMatrix1.Location = new System.Drawing.Point(162, 70);
            this.setNForMatrix1.Name = "setNForMatrix1";
            this.setNForMatrix1.Size = new System.Drawing.Size(89, 26);
            this.setNForMatrix1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(707, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Размерность";
            // 
            // setNForMatrix2
            // 
            this.setNForMatrix2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setNForMatrix2.Location = new System.Drawing.Point(833, 73);
            this.setNForMatrix2.Name = "setNForMatrix2";
            this.setNForMatrix2.Size = new System.Drawing.Size(89, 26);
            this.setNForMatrix2.TabIndex = 19;
            // 
            // inputRandomNumsForMatrix1
            // 
            this.inputRandomNumsForMatrix1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRandomNumsForMatrix1.Location = new System.Drawing.Point(30, 582);
            this.inputRandomNumsForMatrix1.Name = "inputRandomNumsForMatrix1";
            this.inputRandomNumsForMatrix1.Size = new System.Drawing.Size(278, 30);
            this.inputRandomNumsForMatrix1.TabIndex = 20;
            this.inputRandomNumsForMatrix1.Text = "Автоматический ввод";
            this.inputRandomNumsForMatrix1.UseVisualStyleBackColor = true;
            // 
            // inputFromFileForMatrix1
            // 
            this.inputFromFileForMatrix1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFromFileForMatrix1.Location = new System.Drawing.Point(30, 546);
            this.inputFromFileForMatrix1.Name = "inputFromFileForMatrix1";
            this.inputFromFileForMatrix1.Size = new System.Drawing.Size(278, 30);
            this.inputFromFileForMatrix1.TabIndex = 21;
            this.inputFromFileForMatrix1.Text = "Ввод из файла";
            this.inputFromFileForMatrix1.UseVisualStyleBackColor = true;
            this.inputFromFileForMatrix1.Click += new System.EventHandler(this.InputFromFileForMatrix1_Click);
            // 
            // inputRandomNumsForMatrix2
            // 
            this.inputRandomNumsForMatrix2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputRandomNumsForMatrix2.Location = new System.Drawing.Point(711, 582);
            this.inputRandomNumsForMatrix2.Name = "inputRandomNumsForMatrix2";
            this.inputRandomNumsForMatrix2.Size = new System.Drawing.Size(278, 30);
            this.inputRandomNumsForMatrix2.TabIndex = 22;
            this.inputRandomNumsForMatrix2.Text = "Автоматический ввод";
            this.inputRandomNumsForMatrix2.UseVisualStyleBackColor = true;
            // 
            // inputFromFileForMatrix2
            // 
            this.inputFromFileForMatrix2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputFromFileForMatrix2.Location = new System.Drawing.Point(712, 546);
            this.inputFromFileForMatrix2.Name = "inputFromFileForMatrix2";
            this.inputFromFileForMatrix2.Size = new System.Drawing.Size(278, 30);
            this.inputFromFileForMatrix2.TabIndex = 23;
            this.inputFromFileForMatrix2.Text = "Ввод из файла";
            this.inputFromFileForMatrix2.UseVisualStyleBackColor = true;
            // 
            // buttonFullViewMatrix1
            // 
            this.buttonFullViewMatrix1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFullViewMatrix1.Location = new System.Drawing.Point(30, 499);
            this.buttonFullViewMatrix1.Name = "buttonFullViewMatrix1";
            this.buttonFullViewMatrix1.Size = new System.Drawing.Size(279, 30);
            this.buttonFullViewMatrix1.TabIndex = 24;
            this.buttonFullViewMatrix1.Text = "Расширенный просмотр";
            this.buttonFullViewMatrix1.UseVisualStyleBackColor = true;
            // 
            // buttonFullViewMatrix2
            // 
            this.buttonFullViewMatrix2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFullViewMatrix2.Location = new System.Drawing.Point(711, 499);
            this.buttonFullViewMatrix2.Name = "buttonFullViewMatrix2";
            this.buttonFullViewMatrix2.Size = new System.Drawing.Size(279, 30);
            this.buttonFullViewMatrix2.TabIndex = 25;
            this.buttonFullViewMatrix2.Text = "Расширенный просмотр";
            this.buttonFullViewMatrix2.UseVisualStyleBackColor = true;
            // 
            // SumBut
            // 
            this.SumBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SumBut.Location = new System.Drawing.Point(405, 160);
            this.SumBut.Name = "SumBut";
            this.SumBut.Size = new System.Drawing.Size(192, 42);
            this.SumBut.TabIndex = 27;
            this.SumBut.Text = "Сумма";
            this.SumBut.UseVisualStyleBackColor = true;
            // 
            // Dev
            // 
            this.Dev.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dev.Location = new System.Drawing.Point(405, 208);
            this.Dev.Name = "Dev";
            this.Dev.Size = new System.Drawing.Size(192, 42);
            this.Dev.TabIndex = 28;
            this.Dev.Text = "Разность";
            this.Dev.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(405, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 42);
            this.button5.TabIndex = 29;
            this.button5.Text = "Умножение";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(405, 315);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 86);
            this.button6.TabIndex = 30;
            this.button6.Text = "Обратная матрица для первой матрицы";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(405, 407);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 86);
            this.button7.TabIndex = 31;
            this.button7.Text = "Обратная матрица для второй матрицы";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // buttonFullViewMatrix3
            // 
            this.buttonFullViewMatrix3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFullViewMatrix3.Location = new System.Drawing.Point(1200, 499);
            this.buttonFullViewMatrix3.Name = "buttonFullViewMatrix3";
            this.buttonFullViewMatrix3.Size = new System.Drawing.Size(279, 30);
            this.buttonFullViewMatrix3.TabIndex = 32;
            this.buttonFullViewMatrix3.Text = "Расширенный просмотр";
            this.buttonFullViewMatrix3.UseVisualStyleBackColor = true;
            // 
            // SaveMatrix1ToFile
            // 
            this.SaveMatrix1ToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveMatrix1ToFile.Location = new System.Drawing.Point(31, 618);
            this.SaveMatrix1ToFile.Name = "SaveMatrix1ToFile";
            this.SaveMatrix1ToFile.Size = new System.Drawing.Size(278, 30);
            this.SaveMatrix1ToFile.TabIndex = 33;
            this.SaveMatrix1ToFile.Text = "Сохранить в файл";
            this.SaveMatrix1ToFile.UseVisualStyleBackColor = true;
            // 
            // SaveMatrix2ToFile
            // 
            this.SaveMatrix2ToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveMatrix2ToFile.Location = new System.Drawing.Point(711, 618);
            this.SaveMatrix2ToFile.Name = "SaveMatrix2ToFile";
            this.SaveMatrix2ToFile.Size = new System.Drawing.Size(278, 30);
            this.SaveMatrix2ToFile.TabIndex = 34;
            this.SaveMatrix2ToFile.Text = "Сохранить в файл";
            this.SaveMatrix2ToFile.UseVisualStyleBackColor = true;
            // 
            // SaveResultMatrixToFile
            // 
            this.SaveResultMatrixToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveResultMatrixToFile.Location = new System.Drawing.Point(1200, 535);
            this.SaveResultMatrixToFile.Name = "SaveResultMatrixToFile";
            this.SaveResultMatrixToFile.Size = new System.Drawing.Size(278, 30);
            this.SaveResultMatrixToFile.TabIndex = 35;
            this.SaveResultMatrixToFile.Text = "Сохранить в файл";
            this.SaveResultMatrixToFile.UseVisualStyleBackColor = true;
            // 
            // Matrix2ViewOnMainForm
            // 
            this.Matrix2ViewOnMainForm.AllowUserToDeleteRows = false;
            this.Matrix2ViewOnMainForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Matrix2ViewOnMainForm.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Matrix2ViewOnMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrix2ViewOnMainForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.Matrix2ViewOnMainForm.Location = new System.Drawing.Point(712, 160);
            this.Matrix2ViewOnMainForm.Name = "Matrix2ViewOnMainForm";
            this.Matrix2ViewOnMainForm.Size = new System.Drawing.Size(279, 333);
            this.Matrix2ViewOnMainForm.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Строка";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Столбец";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // ResultMatrixViewOnMainForm
            // 
            this.ResultMatrixViewOnMainForm.AllowUserToDeleteRows = false;
            this.ResultMatrixViewOnMainForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultMatrixViewOnMainForm.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.ResultMatrixViewOnMainForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultMatrixViewOnMainForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ResultMatrixViewOnMainForm.Location = new System.Drawing.Point(1199, 160);
            this.ResultMatrixViewOnMainForm.Name = "ResultMatrixViewOnMainForm";
            this.ResultMatrixViewOnMainForm.Size = new System.Drawing.Size(279, 333);
            this.ResultMatrixViewOnMainForm.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Значение";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Строка";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Столбец";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(27, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 24);
            this.label9.TabIndex = 38;
            this.label9.Text = "Первая матрица";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(707, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 24);
            this.label10.TabIndex = 39;
            this.label10.Text = "Вторая матрица";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1195, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 24);
            this.label11.TabIndex = 40;
            this.label11.Text = "Результирующая матрица";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1512, 693);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ResultMatrixViewOnMainForm);
            this.Controls.Add(this.Matrix2ViewOnMainForm);
            this.Controls.Add(this.SaveResultMatrixToFile);
            this.Controls.Add(this.SaveMatrix2ToFile);
            this.Controls.Add(this.SaveMatrix1ToFile);
            this.Controls.Add(this.buttonFullViewMatrix3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Dev);
            this.Controls.Add(this.SumBut);
            this.Controls.Add(this.buttonFullViewMatrix2);
            this.Controls.Add(this.buttonFullViewMatrix1);
            this.Controls.Add(this.inputFromFileForMatrix2);
            this.Controls.Add(this.inputRandomNumsForMatrix2);
            this.Controls.Add(this.inputFromFileForMatrix1);
            this.Controls.Add(this.inputRandomNumsForMatrix1);
            this.Controls.Add(this.setNForMatrix2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.setNForMatrix1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputColumnForFirstMatrix2OnMainForm);
            this.Controls.Add(this.inputRowForFirstMatrix2OnMainForm);
            this.Controls.Add(this.inputValueForFirstMatrix2OnMainForm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputColumnForFirstMatrix1OnMainForm);
            this.Controls.Add(this.inputRowForFirstMatrix1OnMainForm);
            this.Controls.Add(this.inputValueForFirstMatrix1OnMainForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Matrix1ViewOnMainForm);
            this.Name = "mainForm";
            this.Text = "CalcMatrix";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Matrix1ViewOnMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrix2ViewOnMainForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultMatrixViewOnMainForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Matrix1ViewOnMainForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputValueForFirstMatrix1OnMainForm;
        private System.Windows.Forms.TextBox inputRowForFirstMatrix1OnMainForm;
        private System.Windows.Forms.TextBox inputColumnForFirstMatrix1OnMainForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputColumnForFirstMatrix2OnMainForm;
        private System.Windows.Forms.TextBox inputRowForFirstMatrix2OnMainForm;
        private System.Windows.Forms.TextBox inputValueForFirstMatrix2OnMainForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox setNForMatrix1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox setNForMatrix2;
        private System.Windows.Forms.Button inputRandomNumsForMatrix1;
        private System.Windows.Forms.Button inputFromFileForMatrix1;
        private System.Windows.Forms.Button inputRandomNumsForMatrix2;
        private System.Windows.Forms.Button inputFromFileForMatrix2;
        private System.Windows.Forms.Button buttonFullViewMatrix1;
        private System.Windows.Forms.Button buttonFullViewMatrix2;
        private System.Windows.Forms.Button SumBut;
        private System.Windows.Forms.Button Dev;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonFullViewMatrix3;
        private System.Windows.Forms.Button SaveMatrix1ToFile;
        private System.Windows.Forms.Button SaveMatrix2ToFile;
        private System.Windows.Forms.Button SaveResultMatrixToFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.DataGridView Matrix2ViewOnMainForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView ResultMatrixViewOnMainForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

