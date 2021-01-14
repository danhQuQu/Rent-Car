using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Staff : Person
    {
        private double salaryperday;
        private double dayNum;
        // get set
        public double Salaryperday
        {
            get { return this.salaryperday; }
            set { this.salaryperday = value; }
        }
        public double DayNum
        {
            get { return this.dayNum; }
            set { this.dayNum = value; }
        }
        public Staff() : base()
        {

        }
        public Staff(string Fullname, string Sex, string ContactNum, int ID, double Salaryperday, double DayNum) : base(Fullname, Sex, ContactNum, ID)
        {
            this.salaryperday = Salaryperday;
            this.dayNum = DayNum;
        }
        public override void input()
        {
            base.input();
            Console.WriteLine("Enter Salaryperday: ");
            this.Salaryperday = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Number day work: ");
            this.DayNum = Convert.ToDouble(Console.ReadLine());
        }
        public void input(string Fullname, string Sex, string ContactNum, int ID, double Salaryperday, double DayNum)
        {
            base.input(Fullname, Sex, ContactNum, ID);
            this.salaryperday = Salaryperday;
            this.dayNum = DayNum;
        }

        public override double calMoney()
        {
            return this.Salaryperday * this.dayNum;
        }
    }
}
