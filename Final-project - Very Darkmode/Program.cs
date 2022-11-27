using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program{   //หลังจากLoging

    static LetseeMenuB letseemenuB;
   

    static void Main(string[] args) {
          
        PrepareMenuBWhenProgramIsLoaded();
        ShowMainMenuBScreen();
    }

    static void PrepareMenuBWhenProgramIsLoaded() 
    {
        Program.letseemenuB = new LetseeMenuB();
    }

    static void ShowMainMenuBScreen() 
    {
        Program.letseemenuB.PrintMenuBScreen();
    }
   



}



