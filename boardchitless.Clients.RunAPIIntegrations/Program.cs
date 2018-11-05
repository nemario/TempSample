using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boardchitless.Clients.RunAPIIntegrations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BoardChitless - API Integrations");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("  1: Something ");
            Console.WriteLine("  2: Something ");
            Console.WriteLine("  3: Something ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1) {
                Console.WriteLine("You selected 1.");
            }
            else if (num == 2) {
                Console.WriteLine("You selected 2.");
            }
            else if (num == 3)
            {
                Console.WriteLine("You selected 3.");
            }

            System.Threading.Thread.Sleep(5000);
        }
    }
}
