using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class RentCar
    {
        private int dayrent;
        private Customer customer;
        private List<Car> lstcar;
        public int Dayrent
        {
            get { return this.dayrent; }
            set { this.dayrent = value; }
        }
        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }
        public List<Car> Lstcar
        {
            get { return this.lstcar; }
            set { this.lstcar = value; }
        }

        public RentCar()
        {

        }
        public RentCar(int dayrent, Customer customer, List<Car> lstcar)
        {
            this.dayrent = dayrent;
            this.customer = customer;
            this.lstcar = lstcar;
        }
        public void input()
        {
            Console.WriteLine("Thong tin khach thue xe :");
            Customer = new Customer();
            Customer.input();
            int Numofcar = 0;
            Console.WriteLine("nhap so so luong xe muon thue : ");
            Numofcar = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so ngay thue xe: ");
            dayrent = int.Parse(Console.ReadLine());
            for (int i = 1; i < Numofcar; i++)
            {
                Car cs = new Car();
                cs.Input();
                lstcar.Add(cs);
            }
        }
        public void output()
        {
            Console.WriteLine("Thong tin thue xe : ");
            Console.WriteLine("{0}     thue {1} ngay", customer, dayrent);
            Console.WriteLine("so luong xe thue : ");
            for (int i = 0; i < Lstcar.Count; i++)
            {
                Console.WriteLine(lstcar[i]);
            }
        }
        public double tinhTien()
        {
            double tong = 0;
            Console.WriteLine("tong can thanh toan");
            for (int i = 1; i < lstcar.Count; i++)
            {
                tong += lstcar[i].Price;
            }
            return tong;
        }
    }
}
