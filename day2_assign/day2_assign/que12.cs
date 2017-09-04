using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_assign
{
    class que12
    {
        public void cal_bill()
        {
            double charge ;
            double total, Surchage_total=0, grandtotal=0;
            Console.WriteLine("enter the customer id");
            int custid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the customer name");
            string custName =Console.ReadLine();
            Console.WriteLine("enter the units consumed");
            int units = Convert.ToInt32(Console.ReadLine());
            if (units < 199)
            {
                charge = 1.20;
            }
            else if(units>=200 && units<400)
            {
                charge = 1.50;
            }
            else if(units >=400 && units<600)
            {
                charge = 1.80;
            }
            else
            {
                charge = 2;
            }
            total = units * charge;
            if(total>400)
            {
                Surchage_total = total * 0.15;
                grandtotal = total + Surchage_total;

            }
            else if(total<100)
            {
                total = 100;
            }
            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer IDNO                       :{0}\n", custid);
            Console.Write("Customer Name                       :{0}\n", custName);
            Console.Write("unit Consumed                       :{0}\n", units);
            Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n",charge , total);
            Console.Write("Surchage Amount                     :{0}\n", Surchage_total);
            Console.Write("Net Amount Paid By the Customer     :{0}\n", grandtotal);
        }

        
       
    }
}
