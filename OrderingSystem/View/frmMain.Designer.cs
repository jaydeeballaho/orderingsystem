namespace OrderingSystem
{
    partial class frmMain
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
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lblContact = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.Panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.Location = new System.Drawing.Point(12, 12);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(645, 655);
            this.flowPanel.TabIndex = 0;
            // 
            // Panel8
            // 
            this.Panel8.BackColor = System.Drawing.Color.White;
            this.Panel8.Controls.Add(this.dgvOrderList);
            this.Panel8.Location = new System.Drawing.Point(657, 16);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(440, 392);
            this.Panel8.TabIndex = 5;
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
            this.DataGridViewTextBoxColumn2,
            this.Column4,
            this.Column7,
            this.DataGridViewTextBoxColumn3});
            this.dgvOrderList.EnableHeadersVisualStyles = false;
            this.dgvOrderList.GridColor = System.Drawing.Color.White;
            this.dgvOrderList.Location = new System.Drawing.Point(10, 9);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersVisible = false;
            this.dgvOrderList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOrderList.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvOrderList.RowTemplate.Height = 30;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(420, 370);
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
            // DataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewTextBoxColumn2.HeaderText = "Product";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DataGridViewTextBoxColumn2.Width = 158;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column4.Width = 80;
            // 
            // Column7
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column7.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column7.HeaderText = "Quantity";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 80;
            // 
            // DataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewTextBoxColumn3.HeaderText = "Total";
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOrder.Location = new System.Drawing.Point(883, 558);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(100, 47);
            this.btnOrder.TabIndex = 34;
            this.btnOrder.Text = "New\r\nOrder";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Subtotal:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(995, 558);
            this.btnPay.Margin = new System.Windows.Forms.Padding(5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 104);
            this.btnPay.TabIndex = 36;
            this.btnPay.Text = "Pay (₱)";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btnClear.Location = new System.Drawing.Point(883, 615);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 47);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.White;
            this.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.LightCoral;
            this.btnAddCustomer.Location = new System.Drawing.Point(657, 558);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(100, 47);
            this.btnAddCustomer.TabIndex = 38;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(881, 422);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 25);
            this.panel2.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(881, 450);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 25);
            this.panel3.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Discount:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(881, 516);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(112, 25);
            this.panel4.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Total:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(983, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 25);
            this.panel1.TabIndex = 49;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(112, 25);
            this.lblTotal.TabIndex = 45;
            this.lblTotal.Text = "₱0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblDiscount);
            this.panel5.Location = new System.Drawing.Point(983, 450);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(112, 25);
            this.panel5.TabIndex = 48;
            // 
            // lblDiscount
            // 
            this.lblDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiscount.Location = new System.Drawing.Point(0, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(112, 25);
            this.lblDiscount.TabIndex = 35;
            this.lblDiscount.Text = "₱0.00";
            this.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblSubTotal);
            this.panel6.Location = new System.Drawing.Point(983, 422);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 25);
            this.panel6.TabIndex = 47;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubTotal.Location = new System.Drawing.Point(0, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(112, 25);
            this.lblSubTotal.TabIndex = 35;
            this.lblSubTotal.Text = "₱0.00";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(983, 481);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(112, 25);
            this.panel7.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "₱0.00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(881, 481);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(112, 25);
            this.panel9.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "TAX:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lblAddress);
            this.panel10.Location = new System.Drawing.Point(657, 481);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(213, 25);
            this.panel10.TabIndex = 52;
            // 
            // lblAddress
            // 
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(0, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(213, 25);
            this.lblAddress.TabIndex = 35;
            this.lblAddress.Text = "Address:";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.lblName);
            this.panel11.Location = new System.Drawing.Point(657, 450);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(213, 25);
            this.panel11.TabIndex = 51;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(213, 25);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Name: 1 Guest";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label11);
            this.panel12.Location = new System.Drawing.Point(657, 422);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(112, 25);
            this.panel12.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Customer Info:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.lblContact);
            this.panel13.Location = new System.Drawing.Point(657, 509);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(213, 25);
            this.panel13.TabIndex = 53;
            // 
            // lblContact
            // 
            this.lblContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContact.Location = new System.Drawing.Point(0, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(213, 25);
            this.lblContact.TabIndex = 35;
            this.lblContact.Text = "Contact:";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.White;
            this.btnProducts.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProducts.Location = new System.Drawing.Point(770, 558);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(5);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(100, 47);
            this.btnProducts.TabIndex = 54;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Gray;
            this.btnExit.Location = new System.Drawing.Point(657, 615);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 47);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.White;
            this.btnHistory.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.Location = new System.Drawing.Point(770, 615);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(5);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(100, 47);
            this.btnHistory.TabIndex = 57;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1109, 677);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.Panel8);
            this.Controls.Add(this.flowPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Restaurant Ordering System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Panel Panel8;
        internal System.Windows.Forms.DataGridView dgvOrderList;
        internal System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnPay;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        internal System.Windows.Forms.Button btnProducts;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnHistory;
    }
}

