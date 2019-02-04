using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattingCalac
{
    class Program
    {
        static void Main(string[] args)
        {

            DataCalections();

        }

        public static void DataCalections()
        {
            double uBB, BB, IBB, HBP, singles, doubles, triples, HR, AB, SF, H, ;


            Console.WriteLine("Welcome to the wOBA calculator");
            Console.WriteLine("Enter the amount of unintentional walks");
            uBB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of walks");
            BB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of intentional walks");
            IBB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of hit by pitches");
            HBP = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the players hits");
            H = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of homeruns");
            HR = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of doubles");
            doubles = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of triples");
            triples = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the players singles");
            singles = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of at bats");
            AB = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of sacrfice fly's");
            SF = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the players singles");

            BattingAvrage(AB, H);
            Slugging(singles, doubles, triples, HR, AB);
            wOBAcalculator(uBB, BB, IBB, HBP, singles, doubles, triples, HR, AB, SF);
        }

        public static void BattingAvrage(double AB, double H)
        {
            double BatAv;

            BatAv = H / AB;
            Console.WriteLine("\nThe players batting avrage is {0}", BatAv = Math.Round(BatAv, 3));

        }

        public static void Slugging(double singles, double doubles, double triples, double HR, double AB)
        {
            double slugging, totalbases;

            totalbases = singles + doubles * 2 + triples * 3 + HR * 4;

            slugging = totalbases / AB;

            Console.WriteLine("The players slugging is {0}", slugging = Math.Round(slugging, 3));
        }

        public static void wOBAcalculator(double uBB, double BB, double IBB, double HBP, double singles, double doubles, double triples, double HR, double AB, double SF)
        {

            double answer1, answer2, wOBA;

            answer1 = .69 * uBB + .72 * HBP + .89 * singles + 1.27 * doubles + 1.62 * triples + 2.10 * HR;
            answer2 = AB + BB - IBB + SF + HBP;
            wOBA = answer1 / answer2;

            Console.WriteLine("The wOBA befor rounding is {0}", wOBA = Math.Round(wOBA, 3));

        }

        public static void KPercentage()
        {
            //Kpercentage shit
        }

    }
}
