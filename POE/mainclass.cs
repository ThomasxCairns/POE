using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace POE
{
    internal class mainclass
    {


        static void Main(string[] args)
        {
            //boolean flag value for asking user later on if they would like to redo the recipe
            Boolean flag = true;
            do
            {
                ingredients[] arr = new ingredients[100]; // creating the ingredients array
                Stepss[] arr1 = new Stepss[100]; //creating the steps array
                ingredients ing = new ingredients(); //calling the constructor of the ingredients class
                Stepss stps = new Stepss(); //calling the constructor of the steps class
                Console.WriteLine("Enter the namme of your recipe");
                string recpn = Console.ReadLine();
                Console.WriteLine("please enter the number of ingredients");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("enter the name of the ingredient");
                    ing.Name = Console.ReadLine();
                    Console.WriteLine("enter the quantity");
                    ing.Quantity = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the unit of measurement");
                    ing.Unit = Console.ReadLine();
                    arr[i] = new ingredients(ing.Name, ing.Quantity, ing.Unit); //inserting all values into the ingredients array

                }

                Console.WriteLine("How many number of steps are there ?");
                int steps = Convert.ToInt32(Console.ReadLine());
                for (int y = 1; y < steps+1; y++)
                {
                    
                    Console.WriteLine("Enter step " + y + "'s description");
                    stps.Description = Console.ReadLine();
                    arr1[y] = new Stepss(stps.Description); //inserting all the values into the steps array
                }


                Console.WriteLine("Would you like to scale the recipe ? (y) yes or (n) no");
                string choice = Console.ReadLine();
                Boolean flag1 = true;
                if (choice == "n")
                {
                    flag1 = false;
                }
                while(flag1 == true)
                {
                    string scale;
                    Console.WriteLine("scaled by a factor of (half), (double) or (triple)");
                    scale = Console.ReadLine();
                        
                        if (scale == "half")
                        {
                            Double[] Halfarr = new Double[100];
                            for (int i = 0; i < num; i++)
                            {
                                Halfarr[i] = arr[i].Quantity * 0.5;
                            }
                        }
                        else if (scale == "double")
                        {
                            Double[] Darr = new Double[100];
                            for (int i = 0; i < num; i++)
                            {
                                Darr[i] = arr[i].Quantity * 2;
                            }
                        }
                        else if (scale == "tripple")
                        {
                            Double[] Tarr = new Double[100];
                            for (int i = 0; i < num; i++)
                            {
                                Tarr[i] = arr[i].Quantity * 3;
                            }
                        }
                        else
                        {
                            Console.WriteLine("please enter a valid number");
                        }
                        
                    
                    Console.WriteLine("Would you like the values to be set back to their origional values ? (y) yes or (n) no");
                    String ans = Console.ReadLine();
                    if (ans == "y")
                    {
                        Console.WriteLine("==========================================================================================");
                        Console.WriteLine("The ingredients are as follows :");
                        for (int x = 0; x < num; x++)
                        {
                            Console.WriteLine(arr[x].Quantity + " " + arr[x].Unit + " of " + arr[x].Name + ".");
                        }
                        Console.WriteLine("With the steps as follows :");
                        for (int z = 1; z < steps + 1; z++)
                        {
                            
                            Console.WriteLine("Step " + z + " " + arr1[z].Description);
                            
                        }
                    }
                    else if (ans == "n")
                    {
                        if (scale == "half")
                        {
                            Double[] Halfarr = new Double[100];
                            for (int i = 0; i < num; i++)
                            {
                                Halfarr[i] = arr[i].Quantity * 0.5;
                            }

                            Console.WriteLine("==========================================================================================");
                            Console.WriteLine("The ingredients are as follows :");
                            for (int x = 0; x < num; x++)
                            {
                                Console.WriteLine(Halfarr[x] + " " + arr[x].Unit + " of " + arr[x].Name + ".");
                            }
                            Console.WriteLine("With the steps as follows :");
                            for (int z = 1; z < steps + 1; z++)
                            {
                                
                                Console.WriteLine("Step " + z + " " + arr1[z].Description);
                                
                            }
                        }
                        else if (scale == "double")
                        {
                            Double[] Darr = new Double[100];
                            for (int i = 0; i < num; i++)
                            {
                                Darr[i] = arr[i].Quantity * 2;
                            }
                            Console.WriteLine("==========================================================================================");
                            Console.WriteLine("The ingredients are as follows :");
                            for (int x = 0; x < num; x++)
                            {
                                Console.WriteLine(Darr[x] + " " + arr[x].Unit + " of " + arr[x].Name + ".");
                            }
                            Console.WriteLine("With the steps as follows :");
                            for (int z = 1; z < steps + 1; z++)
                            {
                                
                                Console.WriteLine("Step " + z+ " " + arr1[z].Description);
                                
                            }
                        }
                        else if (scale == "triple")
                        {
                            Double[] Tarr = new Double[100];
                            for (int i = 0; i < num; i++)
                            {
                                Tarr[i] = arr[i].Quantity * 3;
                            }
                            Console.WriteLine("==========================================================================================");
                            Console.WriteLine("The ingredients are as follows :");
                            for (int x = 0; x < num; x++)
                            {
                                Console.WriteLine(Tarr[x] + " " + arr[x].Unit + " of " + arr[x].Name + ".");
                            }
                            Console.WriteLine("With the steps as follows :");
                            for (int z = 1; z < steps + 1; z++)
                            {
                                
                                Console.WriteLine("Step " + z + " " + arr1[z].Description);
                                
                            }
                        }
                    }
                    flag1 = false;
                } 
                Console.WriteLine("==============================ORIGIONAL====================================");
                Console.WriteLine("The ingredients are as follows :");
                for (int x = 0; x < num; x++)
                {
                    Console.WriteLine(arr[x].Quantity + " " + arr[x].Unit + " of " + arr[x].Name + ".");
                }
                Console.WriteLine("With the steps as follows :");
                for (int z = 1; z < steps+1; z++)
                {
                    
                    Console.WriteLine("Step " + z + " " + arr1[z].Description);
                    
                }

                Console.WriteLine("Would you like to clear to enter a new recipe?(y) or (n)");
                string clear = Console.ReadLine();
                if (clear == "n")
                {
                    flag = false;
                }
            } while (flag== true);
        }
      
    }
}