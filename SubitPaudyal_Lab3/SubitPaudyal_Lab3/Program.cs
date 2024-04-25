using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SubitPaudyal_Lab3                 /*Subit Paudyal. Section 3. Lab 3*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // once the console run, it will display the msg and asks for user's input.
            Console.Write("Please enter message to display: ");
            
            bool isItRunning = true;
            while (isItRunning == true)
            {
                            
                // user's input for message is stored as string message.
               string message = Console.ReadLine();

                if (message == "exit")
                {
                    isItRunning = false; // exit the program when user inputs 'exit' on the application.
                    break;
                }
                //user will input the size of the banner below.
                Console.Write("Please enter the width for your banner: ");
                
                int width = int.Parse(Console.ReadLine()); //user's input for banner size is stored as width variable.
                int msgLength = message.Length; //this will determine the lenght of the message the user typed.
                while (width < (msgLength+2)) // if user's try to print the banner smaller then their message, the error message in the next few lines will display on console. 
                {
                    Console.WriteLine();
                    Console.WriteLine("Width for the banner needs to be at-least 2 characters greater than the message for banner");
                    Console.Write("Please enter the width for your banner again: ");
                    width = int.Parse(Console.ReadLine()); // so that we can take user's input for the width again.
                }

                char[] msgChar = message.ToCharArray(); // using char array to get the middle point to centralize the message on banner.
                int widthMiddle = (width / 2); //determining middle of the width of the banneras per user's input.
                int messageMiddle= (msgLength / 2); //determining middle of the message as per user's input.
                                
                {// for top of the banner
                    /*for (int i = 2; i <= width; i++)*///same as below. one is "while" statement and another is "for" statemennt.
                    int i = 0;
                     while (i < width)

                     {
                        Console.Write("*");
                        i++;// if i++ is not mentioned, i will always be 1 and "*" keeps on printing as the i=1 condition is always true. 
                     }
                     Console.WriteLine();

                    //for the middle of the banner.
                     int j = 0;
                     while(j < width)
                     {
                        if ((j <= widthMiddle) && (j + messageMiddle >= widthMiddle))      // if both provided condition is true;
                        {                                                                  //the characters before the middle will print on the banner.
                            Console.Write(msgChar[j + messageMiddle - widthMiddle]);
                        }

                        else if ((j >= widthMiddle) && (j - widthMiddle < msgLength - messageMiddle))   //if both provided condition is true;
                        {                                                                               //the the middle and above characters from user's inout will print on the banner.                                                                                    
                            Console.Write(msgChar[j + messageMiddle - widthMiddle]);

                        }
                        else if (j==0 || j == (width - 1))    //and the beginning and end of the banner on the second line is printed with '*'.
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(" "); // this will add space where the characters arent printed.
                        }
                        j++;
                        
                     }
                     Console.WriteLine();  // this will print the 3rd line of the banner on the next line

                    // for the last line of the banner.
                    int k = 0;
                    while (k < width)
                    {
                        Console.Write("*");
                        k++;// if this declaration is not mentioned, the while condition is always true and the the "**" gets printed infinite times at end of the banner.
                    }

                    Console.WriteLine();// just a line break for user readability.
                    Console.WriteLine();// so that the message below gets printed on a new line
                    Console.WriteLine("If you would like to print another banner, please enter a message. OR");
                    Console.WriteLine("If you would like to exit the program, please type 'exit' then press enter.");
                    
                }
                
            }
        }
    }
            
            
}

  

