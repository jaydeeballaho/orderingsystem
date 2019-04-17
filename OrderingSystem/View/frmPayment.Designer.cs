namespace OrderingSystem
{
    partial class frmPayment
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(12, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 71);
            this.panel2.TabIndex = 45;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(171, 15);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 40);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "PAY";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtChange);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCash);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Location = new System.Drawing.Point(12, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 206);
            this.panel1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOTAL:";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.SkyBlue;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(180, 27);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(230, 46);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "CASH:";
            // 
            // txtCash
            // 
            this.txtCash.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtCash.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(180, 79);
            this.txtCash.MaxLength = 10;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(230, 46);
            this.txtCash.TabIndex = 2;
            this.txtCash.Text = "0.00";
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(26, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "CHANGE:";
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.Moccasin;
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChange.Location = new System.Drawing.Point(180, 131);
            this.txtChange.MaxLength = 10;
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(230, 46);
            this.txtChange.TabIndex = 4;
            this.txtChange.Text = "0.00";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChange.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(13, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(436, 71);
            this.panel3.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(302, 40);
            this.label5.TabIndex = 6;
            this.label5.Text = "CUSTOMER PAYMENT";
            // 
            // frmPayment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(463, 383);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
    }
}