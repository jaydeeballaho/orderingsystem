namespace OrderingSystem
{
    partial class frmHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.White;
            this.Panel8.Controls.Add(this.dgvOrderList);
            this.Panel8.Location = new System.Drawing.Point(14, 62);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(533, 392);
            this.Panel8.TabIndex = 6;
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.AllowUserToResizeColumns = false;
            this.dgvOrderList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.White;
            this.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderList.ColumnHeadersHeight = 35;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn1,
            this.Column1,
            this.DataGridViewTextBoxColumn2,
            this.Column4,
            this.Column7,
            this.DataGridViewTextBoxColumn3});
            this.dgvOrderList.EnableHeadersVisualStyles = false;
            this.dgvOrderList.GridColor = System.Drawing.Color.White;
            this.dgvOrderList.Location = new System.Drawing.Point(9, 9);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersVisible = false;
            this.dgvOrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrderList.RowTemplate.Height = 30;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(514, 370);
            this.dgvOrderList.TabIndex = 1;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "ID";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataGridViewTextBoxColumn1.Visible = false;
            this.DataGridViewTextBoxColumn1.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 50;
            // 
            // DataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTextBoxColumn2.HeaderText = "Customer Name";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataGridViewTextBoxColumn2.Width = 158;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Order Date";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "Total Qty";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewTextBoxColumn3.HeaderText = "Grand Total";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(14, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(533, 44);
            this.panel3.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "TRANSACTION HISTORY";
            // 
            // frmHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(560, 467);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel8);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHistory";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmHistory_Load);
            this.Panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel8;
        internal System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}