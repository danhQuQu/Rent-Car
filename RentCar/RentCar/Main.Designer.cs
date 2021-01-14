namespace RentCar
{
    partial class Main
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
            this.datalstCar = new System.Windows.Forms.DataGridView();
            this.dataView2 = new System.Windows.Forms.DataGridView();
            this.labelListCar = new System.Windows.Forms.Label();
            this.lbXeCon = new System.Windows.Forms.Label();
            this.btnThue = new System.Windows.Forms.Button();
            this.btnlistStaff = new System.Windows.Forms.Button();
            this.btnlstCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datalstCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).BeginInit();
            this.SuspendLayout();
            // 
            // datalstCar
            // 
            this.datalstCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalstCar.Location = new System.Drawing.Point(34, 79);
            this.datalstCar.Name = "datalstCar";
            this.datalstCar.RowHeadersWidth = 62;
            this.datalstCar.RowTemplate.Height = 28;
            this.datalstCar.Size = new System.Drawing.Size(509, 459);
            this.datalstCar.TabIndex = 0;
            // 
            // dataView2
            // 
            this.dataView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView2.Location = new System.Drawing.Point(643, 79);
            this.dataView2.Name = "dataView2";
            this.dataView2.RowHeadersWidth = 62;
            this.dataView2.RowTemplate.Height = 28;
            this.dataView2.Size = new System.Drawing.Size(482, 459);
            this.dataView2.TabIndex = 1;
            // 
            // labelListCar
            // 
            this.labelListCar.AutoSize = true;
            this.labelListCar.Location = new System.Drawing.Point(232, 56);
            this.labelListCar.Name = "labelListCar";
            this.labelListCar.Size = new System.Drawing.Size(81, 20);
            this.labelListCar.TabIndex = 2;
            this.labelListCar.Text = "LIST CAR";
            this.labelListCar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbXeCon
            // 
            this.lbXeCon.AutoSize = true;
            this.lbXeCon.Location = new System.Drawing.Point(832, 56);
            this.lbXeCon.Name = "lbXeCon";
            this.lbXeCon.Size = new System.Drawing.Size(121, 20);
            this.lbXeCon.TabIndex = 3;
            this.lbXeCon.Text = "LIST BOOKING";
            // 
            // btnThue
            // 
            this.btnThue.Location = new System.Drawing.Point(34, 571);
            this.btnThue.Name = "btnThue";
            this.btnThue.Size = new System.Drawing.Size(94, 40);
            this.btnThue.TabIndex = 4;
            this.btnThue.Text = "Rent Car";
            this.btnThue.UseVisualStyleBackColor = true;
            // 
            // btnlistStaff
            // 
            this.btnlistStaff.Location = new System.Drawing.Point(153, 571);
            this.btnlistStaff.Name = "btnlistStaff";
            this.btnlistStaff.Size = new System.Drawing.Size(101, 40);
            this.btnlistStaff.TabIndex = 5;
            this.btnlistStaff.Text = "List Staff";
            this.btnlistStaff.UseVisualStyleBackColor = true;
            this.btnlistStaff.Click += new System.EventHandler(this.btnlistStaff_Click);
            // 
            // btnlstCustomer
            // 
            this.btnlstCustomer.Location = new System.Drawing.Point(289, 571);
            this.btnlstCustomer.Name = "btnlstCustomer";
            this.btnlstCustomer.Size = new System.Drawing.Size(121, 40);
            this.btnlstCustomer.TabIndex = 6;
            this.btnlstCustomer.Text = "List Customer";
            this.btnlstCustomer.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 669);
            this.Controls.Add(this.btnlstCustomer);
            this.Controls.Add(this.btnlistStaff);
            this.Controls.Add(this.btnThue);
            this.Controls.Add(this.lbXeCon);
            this.Controls.Add(this.labelListCar);
            this.Controls.Add(this.dataView2);
            this.Controls.Add(this.datalstCar);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalstCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datalstCar;
        private System.Windows.Forms.DataGridView dataView2;
        private System.Windows.Forms.Label labelListCar;
        private System.Windows.Forms.Label lbXeCon;
        private System.Windows.Forms.Button btnThue;
        private System.Windows.Forms.Button btnlistStaff;
        private System.Windows.Forms.Button btnlstCustomer;
    }
}

