using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Store
    {
        private int id;
        private string name;
        private string address;
        private string contactNum;
        private string domain;
        private List<Staff> lstStaff;
        private List<Customer> lstCustomer;
        private List<Car> lstCar;
        private List<RentCar> lstRent;
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string ContactNum
        {
            get { return this.contactNum; }
            set { this.contactNum = value; }
        }
        public string Domain
        {
            get { return this.domain; }
            set { this.domain = value; }
        }
        public List<Staff> LstStaff
        {
            get { return this.lstStaff; }
            set { this.lstStaff = value; }
        }
        public List<Customer> LstCustomer
        {
            get { return this.lstCustomer; }
            set { this.lstCustomer = value; }
        }
        public List<Car> LstCar
        {
            get { return this.lstCar; }
            set { this.lstCar = value; }
        }
        public List<RentCar> LstRent
        {
            get { return this.lstRent; }
            set { this.lstRent = value; }
        }

        public Store()
        {

        }
        public Store(int id, string name, string address, string contactNum, string domain, List<Staff> lstStaff, List<Customer> lstCustomer, List<Car> lstCar, List<RentCar> lstRent)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.contactNum = contactNum;
            this.domain = domain;
            this.lstStaff = lstStaff;
            this.lstCustomer = lstCustomer;
            this.lstCar = lstCar;
            this.lstRent = lstRent;
        }
        public void input()
        {

        }
        public void output()
        {

        }
        public void listCustomer()
        {
            for (int i = 0; i < LstCustomer.Count; i++)
            {
                LstCustomer[i].output();
            }
        }
        public void listStaff()
        {
            for (int i = 0; i < LstStaff.Count; i++)
            {
                LstStaff[i].output();
            }
        }
        public double tongLuong()
        {
            double tong = 0;
            for (int i = 0; i < LstStaff.Count; i++)
            {

            }
            return tong;
        }
        public void Khoitao()
        {
            List<Car> l1 = new List<Car>();
            Car car1 = new Car(1, "XE 1", 100, "bmw", "den", 2020);
            l1.Add(car1);
            Car car2 = new Car(1, "XE 2", 100, "bmw", "den", 2020);
            l1.Add(car2);
            Car car3 = new Car(1, "XE 3", 100, "bmw", "den", 2020);
            l1.Add(car3);
            Car car4 = new Car(1, "XE 4", 100, "bmw", "den", 2020);
            l1.Add(car4);
            Car car5 = new Car(1, "XE 5", 100, "bmw", "den", 2020);
            l1.Add(car5);
            this.LstCar = l1;
            List<Staff> lstS = new List<Staff>();
            Staff nv1 = new Staff("danh", "nam", " 012342", 1, 100, 30);
            lstS.Add(nv1);
            Staff nv2 = new Staff("danh", "nam", " 012342", 1, 100, 30);
            lstS.Add(nv2);
            Staff nv3 = new Staff("danh", "nam", " 012342", 1, 100, 30);
            lstS.Add(nv3);
            Staff nv4 = new Staff("danh", "nam", " 012342", 1, 100, 30);
            lstS.Add(nv4);
            Staff nv5 = new Staff("danh", "nam", " 012342", 1, 100, 30);
            lstS.Add(nv4);
            this.LstStaff = lstS;
        }
    }
}
