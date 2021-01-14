namespace RentCar
{
    partial class frmCustomer
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
            this.lbCusName = new System.Windows.Forms.Label();
            this.lbCusSex = new System.Windows.Forms.Label();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusSex = new System.Windows.Forms.TextBox();
            this.txtCusContact = new System.Windows.Forms.TextBox();
            this.lbCusContact = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCusName
            // 
            this.lbCusName.AutoSize = true;
            this.lbCusName.Location = new System.Drawing.Point(27, 44);
            this.lbCusName.Name = "lbCusName";
            this.lbCusName.Size = new System.Drawing.Size(51, 20);
            this.lbCusName.TabIndex = 0;
            this.lbCusName.Text = "Name";
            this.lbCusName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbCusSex
            // 
            this.lbCusSex.AutoSize = true;
            this.lbCusSex.Location = new System.Drawing.Point(27, 96);
            this.lbCusSex.Name = "lbCusSex";
            this.lbCusSex.Size = new System.Drawing.Size(36, 20);
            this.lbCusSex.TabIndex = 1;
            this.lbCusSex.Text = "Sex";
            // 
            // txtCusName
            // 
            this.txtCusName.Location = new System.Drawing.Point(129, 44);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(100, 26);
            this.txtCusName.TabIndex = 2;
            // 
            // txtCusSex
            // 
            this.txtCusSex.Location = new System.Drawing.Point(129, 96);
            this.txtCusSex.Name = "txtCusSex";
            this.txtCusSex.Size = new System.Drawing.Size(100, 26);
            this.txtCusSex.TabIndex = 3;
            this.txtCusSex.TextChanged += new System.EventHandler(this.txtCusSex_TextChanged);
            // 
            // txtCusContact
            // 
            this.txtCusContact.Location = new System.Drawing.Point(129, 148);
            this.txtCusContact.Name = "txtCusContact";
            this.txtCusContact.Size = new System.Drawing.Size(100, 26);
            this.txtCusContact.TabIndex = 5;
            // 
            // lbCusContact
            // 
            this.lbCusContact.AutoSize = true;
            this.lbCusContact.Location = new System.Drawing.Point(27, 148);
            this.lbCusContact.Name = "lbCusContact";
            this.lbCusContact.Size = new System.Drawing.Size(65, 20);
            this.lbCusContact.TabIndex = 4;
            this.lbCusContact.Text = "Contact";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCusContact);
            this.Controls.Add(this.lbCusContact);
            this.Controls.Add(this.txtCusSex);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.lbCusSex);
            this.Controls.Add(this.lbCusName);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCusName;
        private System.Windows.Forms.Label lbCusSex;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusSex;
        private System.Windows.Forms.TextBox txtCusContact;
        private System.Windows.Forms.Label lbCusContact;
    }
}