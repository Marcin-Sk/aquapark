using System;
using System.IO;

//comment
namespace Aquapark
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
            StreamReader myReader = new StreamReader("EntrysAndLeaves.txt");
            string line = "";
            line = myReader.ReadLine();
            myReader.Close();

            string eValue = line.Substring(2, 5);
            string lValue = line.Substring(10, 5);
            int clientValue = solution(eValue, lValue);
            Console.WriteLine("You have to pay: " + clientValue + " Euro");
            }

            catch (DirectoryNotFoundException e) 
            {
                Console.WriteLine("Couldn't find the file. Check directory!");
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file. Please check the filename.");
            }

            catch (Exception e)
            {
                Console.WriteLine("Something is wrong. Please check an error: {0}", e.Message);
            }

            Console.ReadLine();
        }

        public static int solution(string E, string L)
        {
            Program amount = new Program();
            return amount.chargesCalc(E, L);
        }

        //Charges calculation:

        public int chargesCalc(string E, string L)
        {
            int h = 0; //overall number of hours

            int hEntry = int.Parse(E.Substring(0, 2));
            int hLeave = int.Parse(L.Substring(0, 2));

            int mEntry = int.Parse(E.Substring(3, 2));
            int mLeave = int.Parse(L.Substring(3, 2));

            h = hLeave - hEntry;

            if (mEntry < mLeave)
            {
                h++;
            }

            if (h == 0)
            {
                return 0;
            }

            else if (h == 1)
            {
                return 4;
            }

            else
            {
                return (4 + 2 * (h - 1));
            }
        }
    }
}