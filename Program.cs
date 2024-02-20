using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryMoneyManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Lefta pou phra apo prohgoumeng mera : ");
            double yesterdaymoney = Convert.ToDouble(Console.ReadLine());
            Console.Write("Eispraksi tamiou metrhta : ");
            double tamiomoney = Convert.ToDouble(Console.ReadLine());
            Console.Write("Eispraksi tamiou POS : ");
            double posmoney = Convert.ToDouble(Console.ReadLine());
            Console.Write("Poses pliromes pragmatopoihsate shmera ? : ");
            int ap = Convert.ToInt32(Console.ReadLine());
            double sumeksoda = 0;

            if (ap > 0)
            {
                string[] eksoda = new string[ap];
                for (int i = 0; i < ap; i++)
                {
                    int count = i + 1;
                    Console.Write("Dose noumero " + count + " pliromi : ");
                    eksoda[i] = Console.ReadLine();
                    sumeksoda = sumeksoda + Convert.ToDouble(eksoda[i]);
                }             
            }
            else
            {
                sumeksoda = 0;
            }

            double result = sumMeras(yesterdaymoney, tamiomoney, posmoney, sumeksoda);
            Console.WriteLine("to katharo kerdos einai : " + result);
            WriteToFile(result);
            Console.Read();

        }
        static double sumMeras(double ydm , double tm , double pm, double sume) 
        {
            double s = 0;
            s = (tm + pm + sume) - ydm;
            return s;
        }
          static void WriteToFile( double result)
          {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsPath, "bakery.txt");
            if (!File.Exists(filePath))
            {
                // create file
                using (StreamWriter sw = File.CreateText(filePath))
                {
                    sw.WriteLine($"eisodima thn mera {DateTime.Now.ToString()} einai {result} ");
                }
            }
            else  
            {
                //append file
                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    sw.WriteLine($"eisodima thn mera {DateTime.Now.ToString()} einai {result} ");
                }
            }
              
              
          }

    }
}
