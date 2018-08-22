using System;
using SearchFight.DataAccess;
using SearchFight.Models;

namespace SearchFight.Business
{
    public static class InputValidations
    {
        public static bool ValidateInputs(string[] args)
        {
            if(args == null || args.Length <= 1)    return false;
            return true;
        }

        public static bool ValidateInputValues(string[] args)
        {
            bool validInput = false;
            var plData = new ProgrammingLanguageData();
            List<ProgrammingLanguage> listOfProgrammingLanguages = plData.GetProgrammingLanguageList();
            int totalProgLang = 0;

            //Check if all inputs belongs to a Programming Language
            for(int i = 0; i < args.Length; i++)
            {
                foreach (ProgrammingLanguage pl in plData)
                {
                    if(args[i].Equals(pl.Name)){
                        totalProgLang += 1;
                        break;
                    }
                }
            }

            if(totalProgLang == args.Length)    validInput = true;

            return validInput;        
        }
    }
}
