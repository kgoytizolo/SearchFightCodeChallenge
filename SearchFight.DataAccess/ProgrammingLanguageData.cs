using System;
using SearchFight.Models;
using System.Collections.Generic;

namespace SearchFight.DataAccess
{
    public class ProgrammingLanguageData
    {
        //TODO: Webscrapping to get list of current programming languages in the world via Wikipedia
        //Wikipedia page: https://en.wikipedia.org/wiki/List_of_programming_languages
        //File with source code is located in this file. Name: Wiki_List_of_Programming_Languages.html

        public List<ProgrammingLanguage> GetProgrammingLanguageList()
        {
            List<ProgrammingLanguage> listOfProgrammingLanguages = new List<ProgrammingLanguage>();
            ProgrammingLanguage program1 = new ProgrammingLanguage(){ Id= 1, Name ="C++"};
            ProgrammingLanguage program2 = new ProgrammingLanguage(){ Id= 2, Name ="C#"};
            ProgrammingLanguage program3 = new ProgrammingLanguage(){ Id= 3, Name ="COBOL"};
            ProgrammingLanguage program4 = new ProgrammingLanguage(){ Id= 4, Name ="Java"};
            ProgrammingLanguage program5 = new ProgrammingLanguage(){ Id= 5, Name ="JavaScript"};
            ProgrammingLanguage program6 = new ProgrammingLanguage(){ Id= 6, Name ="Go"};
            ProgrammingLanguage program7 = new ProgrammingLanguage(){ Id= 7, Name ="Python"};
            ProgrammingLanguage program8 = new ProgrammingLanguage(){ Id= 8, Name ="Ruby"};
            ProgrammingLanguage program9 = new ProgrammingLanguage(){ Id= 9, Name ="Game Maker Language"};
            ProgrammingLanguage program10 = new ProgrammingLanguage(){ Id= 10,Name ="Kotlin"};

            listOfProgrammingLanguages.Add(program1);
            listOfProgrammingLanguages.Add(program2);
            listOfProgrammingLanguages.Add(program3);
            listOfProgrammingLanguages.Add(program4);
            listOfProgrammingLanguages.Add(program5);
            listOfProgrammingLanguages.Add(program6);
            listOfProgrammingLanguages.Add(program7);
            listOfProgrammingLanguages.Add(program8);
            listOfProgrammingLanguages.Add(program9);
            listOfProgrammingLanguages.Add(program10);      

            return listOfProgrammingLanguages;       
        }

    }
}
