using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Function Demonstation.\n");
                Console.WriteLine("Please Enter Any 2 Pair Of numbers!sd");
                Console.Write("One : ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Two : ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("One More Pair To go...");
                Console.Write("One : ");
                int numberThree = Convert.ToInt32(Console.ReadLine());
                Console.Write("Two : ");
                int numberFour = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("\nLets First see If these pairs were Money!\n");
                Money myFirstMoney = new Money(numberOne, numberTwo);
                Money mySecondMoney = new Money(numberThree, numberFour);

                Console.WriteLine($"\nLets Compare!!");
                Console.WriteLine($"{myFirstMoney.Info()} > {mySecondMoney.Info()} : {myFirstMoney > mySecondMoney}");
                Console.WriteLine($"{myFirstMoney.Info()} < {mySecondMoney.Info()} : {myFirstMoney < mySecondMoney}");
                Console.WriteLine($"{myFirstMoney.Info()} = {mySecondMoney.Info()} : {myFirstMoney == mySecondMoney}");

                Console.WriteLine($"\nLets Check Some Arithmetics!");
                Console.WriteLine($"{myFirstMoney.Info()} + {mySecondMoney.Info()} = {(myFirstMoney + mySecondMoney).Info()}");
                Console.WriteLine($"{myFirstMoney.Info()} - {mySecondMoney.Info()} = {(myFirstMoney - mySecondMoney).Info()}");

                Console.WriteLine("\nLets Create Series!");
                Series myFirstSerie = new Series(myFirstMoney, mySecondMoney);
                Console.WriteLine($"Lets Get Items From Our Series : [({myFirstSerie[0].PairOne}, {myFirstSerie[0].PairTwo}), ({myFirstSerie[1].PairOne}, {myFirstSerie[1].PairTwo})]");




                Console.WriteLine("\nLets Also Display Our Pairs in Complex Number View!");
                ComplexNumber myFirstNumber = new ComplexNumber(numberOne, numberTwo);
                ComplexNumber mySecondNumber = new ComplexNumber(numberThree, numberFour);
                Console.WriteLine($"{myFirstNumber.Info()} + {mySecondNumber.Info()} = {(myFirstNumber + mySecondNumber).Info()}");
                Console.WriteLine($"{myFirstNumber.Info()} - {mySecondNumber.Info()} = {(myFirstNumber - mySecondNumber).Info()}");


                Console.Write("Lets Convert (eur/usd), Pick Currency :");
                string cur = Console.ReadLine();

                if (cur.Equals("usd")){
                    Console.WriteLine($"{myFirstMoney.Info()} = {myFirstMoney.InUSD} USD");
                    Console.WriteLine($"{mySecondMoney.Info()} = {mySecondMoney.InUSD} USD");
                }
                else if(cur.Equals("eur"))
                {
                    Console.WriteLine($"{myFirstMoney.Info()} = {myFirstMoney.InEuro/100} EURO");
                    Console.WriteLine($"{mySecondMoney.Info()} = {mySecondMoney.InEuro/100} EURO");

                }
                else
                {
                    throw new ArgumentException("Unknown Currecy!");
                }
                
            }
            catch(ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
