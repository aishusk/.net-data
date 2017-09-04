using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program p = new Program();
            Employee e = new Employee(1, "aishu", "IT", "XYZ");
            Employee e1 = new Employee(2, "aishu", "comp", "XYZ");
            Employee e2 = new Employee(3, "amara", "mech", "XYZ");
            Employee e3 = new Employee(4, "neel", "entc", "XYZ");
            Employee e4 = new Employee(5, "ankush", "abc", "XYZ");
            Employee e5 = new Employee(6, "rasika", "pqr", "XYZ");
            Employee e6 = new Employee(7, "ninad", "comp", "XYZ");
            e.lambda();

            //CallDelegates(p);
            Console.ReadLine();
        }
        public delegate void CalculateSimpleInterest(int principle);

        public void GetTotalInterest(int principle)
        {

            double SI = (principle * 2 * 1.5) / 100;
            Console.WriteLine("SI is" + SI);
        }
        public void getInterestRatePerYear(int interest)
        {
            double rate = (100 * interest) / 1000 * 2;
            Console.WriteLine("rate is" + rate);
        }
        public double GetTotalInterest1(int principle)
        {

            double SI = (principle * 2 * 1.5) / 100;
            Console.WriteLine("SI is" + SI);
            return SI;
        }
        private static void CallDelegates(Program p)
        {
            //Func<int,double> CalInterest = new Func<int,double>(p.GetTotalInterest1);
            //CalInterest(20);
            Action<int> CalInterest = new Action<int>(p.GetTotalInterest);
            CalInterest(4);
            Console.WriteLine("action");
            // Using Instance method
            CalculateSimpleInterest d0 = new CalculateSimpleInterest(p.GetTotalInterest);
            d0 += new CalculateSimpleInterest(p.getInterestRatePerYear);
            d0(20);

            //using lamda expression
            CalculateSimpleInterest d2 = principle =>
            {
                double SI = (principle * 2 * 1.5) / 100;
                Console.WriteLine("SI (lambda)" + SI);
            };
            d2(20);

            //Using Anonomyous method
            CalculateSimpleInterest d1 = delegate (int principle)
            {
                double SI = (principle * 2 * 1.5) / 100;
                Console.WriteLine("SI is(anonomyous)" + SI);

            };
            d1(20);

        }
    }
}
 
    

