/// Lab-Week2(Graded Assignment)	
/// File Name: HomeWork2
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Aokola
///
///The video game machine at the local arcade output coupons
/// Then stored the three numbers in a variable. The program is compiled so that there is 
/// no compiler error message and then ran. Then the MyFirstProgram.cs is modified so that
/// it also multiplies the same three numbers and stores the result in a variable.
/// Lastly divide the sum of three numbers by the product of the same three numders.
/// Lastly the program is tested. No numbers is used 3 times nor the numbers 1,2,3 as input.
/// When the program is ran correctly, the project published to GitHub and submit the project
/// URL in canvas




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num_coupons = 108;
            int num_coupons_after_candybars, num_coupons_after_gumballs, num_candy_bar, num_gumballs;
            //integer division below discards any remaninder
            num_candy_bar = num_coupons / 10;
            num_coupons_after_candybars = num_coupons % 10;

            //calculate gumballs

            num_gumballs = num_coupons_after_candybars / 3;

            //calculate any leftover num_coupons_after_candybars

            num_coupons_after_gumballs = num_coupons_after_candybars % 3;

            Console.WriteLine("Your {0} coupons can be redeemed for {1} candy bars and {2} gumballs with {3} coupons leftover", num_coupons,
            num_candy_bar, num_gumballs, num_coupons_after_gumballs);
            Console.ReadLine();
        }
    }
}
