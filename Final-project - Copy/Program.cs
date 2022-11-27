using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program{   //หลังจากLoging

    static LetseeMenuB letseemenuB;
   

    static void Main(string[] args) {
        LinkedListB<char> Book_KmuttGKon = new LinkedListB<char>();
        LinkedListB<char> Book_KhunGkmutt = new LinkedListB<char>(); //เพิ่มตั้งเเต่เริ่ม ก่อน login       
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



