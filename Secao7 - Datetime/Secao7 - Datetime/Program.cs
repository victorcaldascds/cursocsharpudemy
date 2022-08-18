using System;
using System.Globalization;

namespace Secao7___Datetime {
    internal class Program {
        static void Main(string[] args) {
            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);
            Console.WriteLine(d4.Ticks);
            DateTime d5 = new DateTime(2000, 8, 15);
            DateTime d6 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d7 = new DateTime(2000, 8, 15, 13, 5, 58, 275);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            DateTime d8 = DateTime.Now;
            DateTime d9 = DateTime.UtcNow;
            DateTime d10 = DateTime.Today;
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            DateTime d11 = DateTime.Parse("2000-08-15");
            DateTime d12 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d13 = DateTime.Parse("15/08/2000");
            DateTime d14 = DateTime.Parse("15/08/2000 13:05:58");
            Console.WriteLine(d11);
            Console.WriteLine(d12);
            Console.WriteLine(d13);
            Console.WriteLine(d14);
            DateTime d15 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",
            CultureInfo.InvariantCulture);
            DateTime d16 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",
            CultureInfo.InvariantCulture);
            Console.WriteLine(d15);
            Console.WriteLine(d16);

        }
    }
}
