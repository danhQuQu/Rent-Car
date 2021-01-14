using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Car
    {
        private double price;
        private string name;
        private int ID;
        private string model;
        private string colour;
        //private double speed;
        //private double power;
        private int yearIntroduced;

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int IDs
        {
            get { return ID; }
            set { ID = value; }
        }
        public string colours
        {
            get { return colour; }
            set { colour = value; }
        }
        public string models
        {
            get { return model; }
            set { model = value; }
        }
        /*public double speeds
        {
            get { return speed; }
            set { speed = value; }
        }*/
        public Car()
        {

        }

        public Car(int iD, string name, double price, string model, string colour, int yearIntroduced)
        {

            this.price = price;
            this.name = name;
            this.ID = iD;
            this.model = model;
            this.colour = colour;
            this.yearIntroduced = yearIntroduced;
        }

        public void Input()
        {
            Console.WriteLine("Nhap thong tin {0} xe : ");
            Console.Write("nhap ten xe : ");
            name = Console.ReadLine();
            Console.Write("Nhap ID cua xe : ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.Write("nhap Model cua xe : ");
            model = Console.ReadLine();
            Console.Write("nhap Colour cua xe : ");
            colour = Console.ReadLine();
            /*Console.Write("nhap toc do cua xe : ");
            speed = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap cong xuat cua xe : ");
            power = Convert.ToDouble(Console.ReadLine());
            Console.Write("nhap nam san xuat cua xe : ");
            yearIntroduced = int.Parse(Console.ReadLine());*/
        }
        public void Output()
        {
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("Thong tin cua xe");
        }
    }
}
