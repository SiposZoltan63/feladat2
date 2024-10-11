using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;

            if (hour < 5)
            {
                Console.WriteLine("Jó éjszakát.");
            }
            else if (hour < 12)
            {
                Console.WriteLine("Jó reggelt.");
            }
            else if (hour < 18)
            {
                Console.WriteLine("Jó napot.");
            }
            else if (hour < 24)
            {
                Console.WriteLine("Jó estét.");
            }
        }
        static double megtakaritas;
        public static void kamat()
        {
            double megtakaritas;
            int betet;
            int kamat;
            int ev;
            Console.WriteLine("Kérem a betét összegét: ");
            betet = int.Parse(Console.ReadLine());
            Console.Write("Kérem a kamtot: ");
            kamat = int.Parse(Console.ReadLine());
            Console.Write("Kérem a megtakarítás hosszát: ");
            ev = int.Parse(Console.ReadLine());
            for (int i = 0;i < ev;i++)
            {
                megtakaritas = kamat / betet * 100;
            }
            return megtakaritas;
        }
    }
}
