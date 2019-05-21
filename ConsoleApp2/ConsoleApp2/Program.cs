using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class payroll
    {
        static void Main(string[] args)
        {



            {
                var payCheck = new PayRateCalculator();
                Console.Write("Please provide the Employees Last Name = salary and wages >>");
                payCheck.lastName = Console.ReadLine();
                Console.Write("How many hours has employee {0} worked? >>", payCheck.lastName);
                payCheck.hours = Convert.ToInt32(Console.ReadLine());
                Console.Write("What is employee {$33.72}'s hourly wage? >>", payCheck.lastName);
                payCheck.payrate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}'s Gross pay is ${1}", payCheck.lastName, payCheck.grossPay);
                Console.WriteLine("{0}'s Net pay is ${1}", payCheck.lastName, payCheck.netPay);
            }
            

         class PayRateCalculator
        {
            private float _payrate = 33.72f;
            private float  _withholdingRate = 0.20F;

            public float hours { get; set; }
            public float grossPay
            {
                get
                {
                    return hours * _payrate;
                }
            }
            public float netPay
            {
                get
                {
                    return grossPay - (grossPay * _withholdingRate);
                }
            }
            public float payrate
            {
                get
                {
                    return _payrate;
                }
                set
                {
                    _payrate = value;
                }
            }
            public string lastName { get; set; }

            public PayRateCalculator(string lastName, float hours, float payRate, float salary )
            {
                this.hours = hours;
                this.payrate = payrate;
                this.lastName = lastName;
            }

            public PayRateCalculator()
            {
                Console.WriteLine(" your anual income is set 80,000");
                Console.WriteLine(" your wages per week is 1348.80");
                Console.WriteLine("payrate is $32.72 per hours");
                Console.WriteLine("payrate calculater");

            }


        }
    }
}
