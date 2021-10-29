using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace output_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name, age, experience, job and Qualification ");

            string details = Console.ReadLine();
            String[] allDetails = details.Split(','); 
                                
          
            foreach (var k in allDetails)
            {
                Console.WriteLine(k);
            }
        }
    }
}
