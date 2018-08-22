using System;
using SearchFight.Messages;
using SearchFight.Business;

namespace SearchFight
{
    class Program
    {
        static void Main(string[] args)
        {            
            try
            {
                if(InputValidations.ValidateInputs(args)){
                    if(InputValidations.ValidateInputValues(args)){
                        //*** Proceed with Search Query Engines using JSON - REST API */
                        Console.WriteLine("Proceed with Search Query Engines using JSON - REST API");
                        //Use Asynchronus calls to handle results
                        //CompareSearchResults.cs
                    }
                    else Console.WriteLine("Error: " + ErrorMessages.programmingError);        
                }
                else Console.WriteLine("Error: " + ErrorMessages.inputError);       
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + ErrorMessages.genericError);
                Console.WriteLine("Error Detail: " + e.Message);
            }
        }
    }
}
