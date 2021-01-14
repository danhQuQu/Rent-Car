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
    public partial class Main : Form
    {
        listStaff tableStaff;
        private int index =-1;
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            Store store1 = new Store();
            store1.Khoitao();
            datalstCar.Columns.Add("column","ID");
            datalstCar.Columns.Add("column", "Name");
            datalstCar.Columns.Add("column", "Model");
            datalstCar.Columns.Add("column", "Color");
            datalstCar.Columns.Add("column", "Price");
            for (int i=0 ; i < store1.LstCar.Count(); i++)
            {
                datalstCar.Rows.Add();
                index++;
                datalstCar.Rows[i].Cells[0].Value = store1.LstCar[i].IDs;
                datalstCar.Rows[i].Cells[1].Value = store1.LstCar[i].Name;
                datalstCar.Rows[i].Cells[2].Value = store1.LstCar[i].models;
                datalstCar.Rows[i].Cells[3].Value = store1.LstCar[i].colours;
                datalstCar.Rows[i].Cells[4].Value = store1.LstCar[i].Price;
            }
        }

        private void btnlistStaff_Click(object sender, EventArgs e)
        {
            tableStaff = new listStaff();
            tableStaff.Show();
        }
    }
}
