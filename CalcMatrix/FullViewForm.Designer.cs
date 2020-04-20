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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullViewForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RightArrow = new System.Windows.Forms.Button();
            this.UpArrow = new System.Windows.Forms.Button();
            this.LeftArrow = new System.Windows.Forms.Button();
            this.DownArrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1642, 948);
            this.dataGridView1.TabIndex = 0;
            // 
            // RightArrow
            // 
            this.RightArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightArrow.BackgroundImage")));
            this.RightArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RightArrow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.RightArrow.Location = new System.Drawing.Point(1814, 540);
            this.RightArrow.Margin = new System.Windows.Forms.Padding(4);
            this.RightArrow.Name = "RightArrow";
            this.RightArrow.Size = new System.Drawing.Size(75, 75);
            this.RightArrow.TabIndex = 20;
            this.RightArrow.UseVisualStyleBackColor = true;
            this.RightArrow.Click += new System.EventHandler(this.RightArrow_Click);
            // 
            // UpArrow
            // 
            this.UpArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpArrow.BackgroundImage")));
            this.UpArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpArrow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.UpArrow.Location = new System.Drawing.Point(1739, 465);
            this.UpArrow.Margin = new System.Windows.Forms.Padding(4);
            this.UpArrow.Name = "UpArrow";
            this.UpArrow.Size = new System.Drawing.Size(75, 75);
            this.UpArrow.TabIndex = 21;
            this.UpArrow.UseVisualStyleBackColor = true;
            this.UpArrow.Click += new System.EventHandler(this.UpArrow_Click);
            // 
            // LeftArrow
            // 
            this.LeftArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftArrow.BackgroundImage")));
            this.LeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LeftArrow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LeftArrow.Location = new System.Drawing.Point(1666, 540);
            this.LeftArrow.Margin = new System.Windows.Forms.Padding(4);
            this.LeftArrow.Name = "LeftArrow";
            this.LeftArrow.Size = new System.Drawing.Size(75, 75);
            this.LeftArrow.TabIndex = 22;
            this.LeftArrow.UseVisualStyleBackColor = true;
            this.LeftArrow.Click += new System.EventHandler(this.LeftArrow_Click);
            // 
            // DownArrow
            // 
            this.DownArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownArrow.BackgroundImage")));
            this.DownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DownArrow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.DownArrow.Location = new System.Drawing.Point(1739, 615);
            this.DownArrow.Margin = new System.Windows.Forms.Padding(4);
            this.DownArrow.Name = "DownArrow";
            this.DownArrow.Size = new System.Drawing.Size(75, 75);
            this.DownArrow.TabIndex = 23;
            this.DownArrow.UseVisualStyleBackColor = true;
            this.DownArrow.Click += new System.EventHandler(this.DownArrow_Click);
            // 
            // FullViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.DownArrow);
            this.Controls.Add(this.LeftArrow);
            this.Controls.Add(this.UpArrow);
            this.Controls.Add(this.RightArrow);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FullViewForm";
            this.Text = "FullViewForm";
            this.Load += new System.EventHandler(this.FullViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RightArrow;
        private System.Windows.Forms.Button UpArrow;
        private System.Windows.Forms.Button LeftArrow;
        private System.Windows.Forms.Button DownArrow;
    }
}