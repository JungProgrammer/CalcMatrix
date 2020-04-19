namespace CalcMatrix
{
    partial class FullViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullViewForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.RightArrow = new System.Windows.Forms.Button();
            this.UpArrow = new System.Windows.Forms.Button();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.DownArrow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1611, 948);
            this.dataGridView1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1643, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Навигация";
            // 
            // RightArrow
            // 
            this.RightArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightArrow.BackgroundImage")));
            this.RightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightArrow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RightArrow.Location = new System.Drawing.Point(1916, 679);
            this.RightArrow.Margin = new System.Windows.Forms.Padding(4);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(115, 106);
            this.RightArrow.TabIndex = 20;
            this.RightArrow.UseVisualStyleBackColor = true;
            this.RightArrow.Click += new System.EventHandler(this.RightArrow_Click);
            // 
            // UpArrow
            // 
            this.UpArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpArrow.BackgroundImage")));
            this.UpArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpArrow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UpArrow.Location = new System.Drawing.Point(1785, 566);
            this.UpArrow.Margin = new System.Windows.Forms.Padding(4);
            this.UpArrow.Name = "UpArrow";
            this.UpArrow.Size = new System.Drawing.Size(127, 106);
            this.UpArrow.TabIndex = 21;
            this.UpArrow.UseVisualStyleBackColor = true;
            this.UpArrow.Click += new System.EventHandler(this.UpArrow_Click);
            // 
            // LeftArrow
            // 
            this.LeftArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftArrow.BackgroundImage")));
            this.LeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftArrow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LeftArrow.Location = new System.Drawing.Point(1648, 679);
            this.LeftArrow.Margin = new System.Windows.Forms.Padding(4);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(127, 106);
            this.LeftArrow.TabIndex = 22;
            this.LeftArrow.UseVisualStyleBackColor = true;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // DownArrow
            // 
            this.DownArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownArrow.BackgroundImage")));
            this.DownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownArrow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DownArrow.Location = new System.Drawing.Point(1785, 793);
            this.DownArrow.Margin = new System.Windows.Forms.Padding(4);
            this.DownArrow.Name = "DownArrow";
            this.DownArrow.Size = new System.Drawing.Size(127, 106);
            this.DownArrow.TabIndex = 23;
            this.DownArrow.UseVisualStyleBackColor = true;
            this.DownArrow.Click += new System.EventHandler(this.DownArrow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(1649, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 297);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // FullViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 977);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DownArrow);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.UpArrow);
            this.Controls.Add(this.RightArrow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FullViewForm";
            this.Text = "FullViewForm";
            this.Load += new System.EventHandler(this.FullViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button RightArrow;
        private System.Windows.Forms.Button UpArrow;
        private System.Windows.Forms.Button LeftArrow;
        private System.Windows.Forms.Button DownArrow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}