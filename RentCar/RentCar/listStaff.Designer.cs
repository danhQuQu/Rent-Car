namespace RentCar
{
    partial class listStaff
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
            this.lblstStaff = new System.Windows.Forms.Label();
            this.datalistStaff = new System.Windows.Forms.DataGridView();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnSumSalary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datalistStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstStaff
            // 
            this.lblstStaff.AutoSize = true;
            this.lblstStaff.Location = new System.Drawing.Point(191, 44);
            this.lblstStaff.Name = "lblstStaff";
            this.lblstStaff.Size = new System.Drawing.Size(98, 20);
            this.lblstStaff.TabIndex = 0;
            this.lblstStaff.Text = "LIST STAFF";
            // 
            // datalistStaff
            // 
            this.datalistStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistStaff.Location = new System.Drawing.Point(43, 76);
            this.datalistStaff.Name = "datalistStaff";
            this.datalistStaff.RowHeadersWidth = 62;
            this.datalistStaff.RowTemplate.Height = 28;
            this.datalistStaff.Size = new System.Drawing.Size(407, 378);
            this.datalistStaff.TabIndex = 1;
            this.datalistStaff.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(43, 488);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(75, 34);
            this.btnAddStaff.TabIndex = 2;
            this.btnAddStaff.Text = "Add";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(195, 488);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 34);
            this.btnDeleteStaff.TabIndex = 3;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSumSalary
            // 
            this.btnSumSalary.Location = new System.Drawing.Point(336, 488);
            this.btnSumSalary.Name = "btnSumSalary";
            this.btnSumSalary.Size = new System.Drawing.Size(114, 34);
            this.btnSumSalary.TabIndex = 4;
            this.btnSumSalary.Text = "Sum Salary";
            this.btnSumSalary.UseVisualStyleBackColor = true;
            // 
            // listStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 582);
            this.Controls.Add(this.btnSumSalary);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.datalistStaff);
            this.Controls.Add(this.lblstStaff);
            this.Name = "listStaff";
            this.Text = "listStaff";
            this.Load += new System.EventHandler(this.listStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalistStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstStaff;
        private System.Windows.Forms.DataGridView datalistStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnSumSalary;
    }
}