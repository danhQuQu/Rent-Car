using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar
{
    class Customer : Person
    {
        public Customer() : base()
        {

        }
        public Customer(string Fullname, string Sex, string ContactNum, int ID) : base(Fullname, Sex, ContactNum, ID)
        {

        }
        public override void input()
        {
            base.input();
        }
        public override void output()
        {
            base.output();
        }
        public override double calMoney()
        {
            return calMoney();
        }
    }
}
