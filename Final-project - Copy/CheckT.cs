using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckT{
    static LetseeMenuB letseemenuB;

    

    public void PrepareMenuBWhenProgramIsLoaded() 
    {
        CheckT.letseemenuB = new LetseeMenuB();
    }

    public void ShowMainMenuBScreen() 
    {
        CheckT.letseemenuB.PrintMenuBScreen();
    }
    public void PrinCheckTingScreen() {
        Console.Clear();

        Checkticket();
        PresentCheckticket();        
        
    }
    public void Checkticket(){
        Console.WriteLine("/****************************/");
        Console.WriteLine("*Today's schedule*");              
        Console.WriteLine("*---*");                   //ตารางเวลา----
        Console.WriteLine("*remaining seats ?/25*");  //รอบรถที่ จำนวนที่นั่ง
        Console.WriteLine("*Check did you booking___*"); //login
        Console.WriteLine("*------------Menu------------*");
        Console.WriteLine("*Back pls input [anything]*");
        Console.WriteLine("/****************************/");
        
    }
    public void PresentCheckticket(){
        Console.Write("Please input Menu:");
        string C1 = (Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Back to Mainmenu.");
        Console.WriteLine("Wait a sec....");
        PrepareMenuBWhenProgramIsLoaded();
        System.Threading.Thread.Sleep(3000);
        ShowMainMenuBScreen();
    }


}