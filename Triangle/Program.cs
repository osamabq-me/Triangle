using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_7
{

    /// <summary>
    /// Main class.
    /// Containes all functions for the program.
    /// </summary>
    public class calculating
    {
        /// <summary>
        /// <param name="THeight">Is the vlaue holder for the Triangle hight </param>
        /// </summary>
        /// <summary>
        /// <param name="TBase"> Is the vlaue holder for the Triangle Base</param>
        /// </summary>
        /// <summary>
        /// <param name="AT"> Is the vlaue holder for Triangle Area</param>
        /// </summary>
        /// <summary>
        /// <param name="A"> Is the vlaue holder for the Triangle Side A length</param>
        /// </summary>
        /// <summary>
        /// <param name="B">Is the vlaue holder for the Triangle Side B length </param>
        /// </summary>
        /// <summary>
        /// <param name="C"> Is the vlaue holder for Triangle Side C length</param>
        /// </summary>
        /// <summary>
        /// <param name="CT"> Is the vlaue holder for Triangle circumference after calculaiton</param>
        /// </summary>
        double THeight, TBase,  AT, A, B, C, CT;

        //Area of Triangle  short AOT
        /// <summary>
        /// This method calculates the Triangle's Area by knowing the  base and Hight.
        /// <param name="TBase"> Is the vlaue holder for the Triangle Base</param>
        /// <param name="THeight">Is the vlaue holder for the Triangle hight </param>
        /// <param name="AT"> Is the vlaue holder for Triangle Area</param>
        /// <example>
        /// For example:
        /// <code>
        /// TBase = 5
        /// THeight = 4
        /// Area Triangle =  (Triangle hight * Triangle Base )/2
        /// At = 10
        /// </code>
        /// </summary>

        public void AOT()
        {
            ///<summary>
            ///Dispaly an input Triangle base to collect data
            Console.Write(" Input Base = ");
            TBase = Convert.ToDouble(Console.ReadLine());

            ///Dispaly an input Triangle Hight to collect data
            Console.Write(" Input Height = ");
            THeight = Convert.ToDouble(Console.ReadLine());
            ///preforms the calculaiton to find the Triangle Area
            AT = ((THeight * TBase) / 2);
            ///Dispaly The result for Triangle Area
            Console.WriteLine(" |=================================|");
            Console.WriteLine(" |The Area of Triangle = " + AT);
            ///</summary>

        }



        //circumference of Triangle short COT

        /// <summary>
        /// This method calculates the Triangle's circumference by knowing all sides lengths.
        /// <param name="A"> Is the vlaue holder for the Triangle Side A length</param>
        /// <param name="B">Is the vlaue holder for the Triangle Side B length </param>
        /// <param name="C"> Is the vlaue holder for Triangle Side C length</param>
        /// <param name="CT"> Is the vlaue holder for Triangle circumference after calculaiton</param>
        /// <example>
        /// For example:
        /// <code>
        /// A = 5
        /// B = 4
        /// C = 6
        /// circumference of Triangle =  A + B + C;
        /// CT = 15
        /// </code>
        /// </summary>
        public void COT()
        {
            //Dispaly an input Triangle side A to collect data
            Console.Write(" Input side A length = ");
            A = Convert.ToDouble(Console.ReadLine());
            //Dispaly an input Triangle side A to collect data
            Console.Write(" Input side B length = ");
            B = Convert.ToDouble(Console.ReadLine());
            //Dispaly an input Triangle side A to collect data
            Console.Write(" Input side C length = ");
            C = Convert.ToDouble(Console.ReadLine());
            //Do the calculaitons 
            CT = (A + B + C);
            //Display the result of calculaiting 
            Console.WriteLine(" |=================================|");
            Console.WriteLine(" |The circumference of Triangle = " + CT);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Calls the main class
            calculating ACC = new calculating();
            //Parameters for the decision
            int choice;
            string decision;
            //Display a meesege for user when opening the app
            Console.WriteLine(" This program will help you find the area and circumference of Triangle");
            Console.WriteLine(" press any key to continue");
            Console.ReadKey();
            Console.Clear();

            decision = ("Y");
            //starting loop
            while ("Y" == decision)
            {

                // program starts from here
                Console.WriteLine(" |=================================|");
                Console.WriteLine(" |Choose what you want to calculate|");
                Console.WriteLine(" |=================================|");
                Console.WriteLine(" |1.Area of Triangle               |");
                Console.WriteLine(" |2.circumference of Triangle      |");
                Console.WriteLine(" |=================================|");
                //Input choice
                Console.WriteLine(" |Select from menu:                |");

                Console.WriteLine(" |=================================|");

                //Accept Choice
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                //Start Switch Case 
                switch (choice)
                {
                    case 1:
                        //calling AOT methode
                        ACC.AOT();
                        break;
                    case 2:
                        //calling COT methode
                        ACC.COT();
                        break;
                    default:
                        //Declare deafult text
                        Console.WriteLine("Wrong choice");
                        Console.ReadKey();
                        break;

                }
                Console.WriteLine("\n");
                // Question for the loop
                Console.WriteLine(" |============================================|");
                Console.WriteLine(" |Do you want to calculate anything else?(Y/N)|");
                Console.WriteLine(" |============================================|");
                decision = Console.ReadLine();
                //IF condition to continue loop or stop it 
                if (decision.Equals("Y") || decision.Equals("y"))
                {
                    decision = ("Y");
                }

                Console.Clear();
            }




        }
    }
}