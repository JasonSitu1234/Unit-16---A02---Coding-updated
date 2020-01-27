

// Able to use class from namespace 

using System;



using System.Collections.Generic;



using System.Linq;



using System.Text;



using System.Threading.Tasks;





// Name space is able to organise the code 

namespace Areacalculator



{

    // Container for data 

    class Program



    {



        static void Main(string[] args)



        {

            // Floating point numbers with decimals 

            double inputOne = 0;



            double inputTwo = 0;



            double radius = 0;


            int opChoice = 0;


            // Will display the message "WELCOME TO AREA CALCULATOR" 

            Console.WriteLine("WELCOME TO AREA CALCULATOR");

            // Line break 

            Console.WriteLine("");

            // Can be used for true or false and for this line it is used for being true 

            bool calcLoop = true;



            while (calcLoop == true)



            {

                // Display the message "WOULD YOU LIKE ASSISTANCE USING THE CALCULATOR? Y/N"  

                Console.WriteLine("WOULD YOU LIKE ASSISTANCE USING THE CALCULATOR? Y/N");



                // Use a string because this is used to store text 

                string helpchoice = Console.ReadLine().ToUpper();

                // Helpchoice means the name of the file 

                if (helpchoice == "Y" | helpchoice == "YES")



                {

                    // Console.WriteLine will display the message inside the parentheses  

                    Console.WriteLine("");



                    Console.WriteLine("Step 1: Enter your first number");



                    Console.WriteLine("Step 2: Enter your second number");



                    Console.WriteLine("Step 3: Insert your radio number");



                    Console.WriteLine("Step 4: Enter the number for area calculation");



                    Console.WriteLine("Step 5: Choosing if you would like to use the calculator again");



                    Console.WriteLine("");



                }

















                // Console.WriteLine will display the message inside the parentheses  
                bool alpha = true;
                while (alpha == true)
                {
                    Console.WriteLine("Choose the area calculation");



                    Console.WriteLine("Enter 1 for rectangle");



                    Console.WriteLine("Enter 2 for triangle");



                    Console.WriteLine("Enter 3 for circle");



                    Console.WriteLine("");





                    // Stores integers 
                    string opChoice1 = Console.ReadLine();
                    bool parse = int.TryParse(opChoice1, out opChoice);
                    if (!parse)
                    {
                        Console.WriteLine("Please enter in the correct format!");
                    }
                    else if(opChoice>=4|opChoice<=0)
                    {
                        Console.WriteLine("Please enter in the correct format!");
                    }
                    else
                    {
                        alpha = false;
                    }

                    Console.WriteLine("");
                    
                }
                    if (opChoice== 1)

                    {

                        //Boolean stores true or false 

                        bool numberOne = false;

                        while (numberOne == false)

                        {

                            Console.Write("Enter your first number: ");

                            string inputString = Console.ReadLine();



                            // Boolean which display true or false  



                            bool parsed = double.TryParse(inputString, out inputOne);

                            if (!parsed)

                            {

                                Console.WriteLine("decimal.TryParse could not parse '{0}' to an int. \n", inputString);

                            }

                            else

                            {

                                numberOne = true;

                            }

                        }

                        bool numberTwo = false;

                        while (numberTwo == false)

                        {

                            Console.Write("Enter your second number: ");

                            string inputString = Console.ReadLine();





                            // If the user tyoes the wrong thing then it will display this message 

                            bool parsed = double.TryParse(inputString, out inputTwo);

                            if (!parsed)

                            {

                                Console.WriteLine("decimal.TryParse could not parse '{0}' to an int. \n", inputString);

                            }

                            else

                            {

                                numberTwo = true;

                            }





                        }

                    }

                    else

                    {

                        bool numberRadius = false;

                        while (numberRadius == false)

                        {

                            Console.Write("Enter your radius number: ");

                            string inputString = Console.ReadLine();



                            bool parsed = double.TryParse(inputString, out radius);

                            if (!parsed)

                            {

                                // If the user tyoes the wrong thing then it will display this message 

                                Console.WriteLine("decimal.TryParse could not parse '{0}' to an int. \n", inputString);

                            }

                            else

                            {

                                numberRadius = true;

                            }

                        }



                    }





                    // The switch allows the variable to be tested 

                    switch (opChoice)



                    {

                        // This is for the rectangle so it would be the length * the width 

                        case 1:



                            Console.WriteLine("\nYour answer is: " + (inputOne * inputTwo).ToString("F") + "m2");



                            break;



                        // This will be the triangle which will be length * width then half it 

                        case 2:



                            Console.WriteLine("\nYour answer is: " + (inputOne * inputTwo / 2).ToString("F") + "m2");



                            break;



                        // This will be the circle which will be radius * radius then it would * Pi which is 3.14  

                        case 3:



                            Console.WriteLine("\nYour answer is: " + (radius * radius * 3.14).ToString("F") + "m2");



                            break;






                    }

                    // Giving a choice to enter "Y" which is yes or "n" which is no 

                    Console.WriteLine("");



                    Console.Write("\nDo you want to continue with this calculator? Y/N: ");



                    string rechoice = Console.ReadLine().ToUpper();







                    if (rechoice == "Y")



                    {

                        // Display the message "Press any key to continue" 

                        Console.WriteLine("press any key to continue");



                        Console.ReadKey();



                    }



                    else



                    {

                        // Display the message "Press any key to exit" 

                        Console.WriteLine("press any key to exit");



                        calcLoop = false;



                    }



                }



            }



            }



        }



    




