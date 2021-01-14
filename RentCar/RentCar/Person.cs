using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    abstract class Person
    {
        protected string fullname;
        protected string sex;
        protected string contactNum;
        protected int id;

        // Get set
        public string Fullname
        {
            get { return this.fullname; }
            set { this.fullname = value; }
        }
        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }
        public string ContactNum
        {
            get { return this.contactNum; }
            set { this.contactNum = value; }
        }
        public int ID
        {
            get { return this.id; }
            set { this.id = value; }
        }
        //Khoi tao
        public Person()
        {

        }
        public Person(string Fullname, string Sex, string ContactNum, int ID)
        {
            this.fullname = Fullname;
            this.sex = Sex;
            this.contactNum = ContactNum;
            this.id = ID;
        }
        public virtual void input()
        {
            Console.WriteLine("Enter Full name: ");
            this.Fullname = Console.ReadLine();
            Console.WriteLine("Enter Sex: ");
            this.Sex = Console.ReadLine();
            Console.WriteLine("Enter contact Number: ");
            this.ContactNum = Console.ReadLine();
            Console.WriteLine("Enter ID: ");
            this.ID = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void output()
        {
            Console.WriteLine("Full name: " + this.fullname);
            Console.WriteLine("Sex: " + this.sex);
            Console.WriteLine("Contact Number: " + this.contactNum);
            Console.WriteLine("ID : " + this.id);
        }
        public virtual void input(string Fullname, string Sex, string ContactNum, int ID)
        {
            this.fullname = Fullname;
            this.sex = Sex;
            this.contactNum = ContactNum;
            this.id = ID;
        }
        public abstract double calMoney(); // tính tiền
    }
}
