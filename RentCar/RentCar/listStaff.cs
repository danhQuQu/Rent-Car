using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCar
{
    public partial class listStaff : Form
    {
        private int index = -1;
        public listStaff()

        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {

        }

        private void listStaff_Load(object sender, EventArgs e)
        {
            Store store1 = new Store();
            store1.Khoitao();
            datalistStaff.Columns.Add("column", "ID");
            datalistStaff.Columns.Add("column", "Full Name");
            datalistStaff.Columns.Add("column", "Sex");
            datalistStaff.Columns.Add("column", "Contact");
            datalistStaff.Columns.Add("column", "Salary/Day");
            datalistStaff.Columns.Add("column", "Days");
            datalistStaff.Columns.Add("column", "Salary");
            for (int i = 0; i < store1.LstCar.Count(); i++)
            {
                datalistStaff.Rows.Add();
                index++;
                datalistStaff.Rows[i].Cells[0].Value = store1.LstStaff[i].ID;
                datalistStaff.Rows[i].Cells[1].Value = store1.LstStaff[i].Fullname;
                datalistStaff.Rows[i].Cells[2].Value = store1.LstStaff[i].Sex;
                datalistStaff.Rows[i].Cells[3].Value = store1.LstStaff[i].ContactNum;
                datalistStaff.Rows[i].Cells[4].Value = store1.LstStaff[i].Salaryperday;
                datalistStaff.Rows[i].Cells[5].Value = store1.LstStaff[i].DayNum;
                datalistStaff.Rows[i].Cells[6].Value = store1.LstStaff[i].calMoney();
            }
        }
    }
}
