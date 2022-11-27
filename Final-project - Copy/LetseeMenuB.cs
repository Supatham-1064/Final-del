using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LetseeMenuB {

    static BookTKmutt bookTkmutt;

    public void PrepareBookTKmuttWhenProgramIsLoaded() 
    {
        LetseeMenuB.bookTkmutt = new BookTKmutt();
    }

    public void ShowBookTkmuttScreen() 
    {
        LetseeMenuB.bookTkmutt.BookKmuttticket();
    }
    //---------------------------------------------//
    static CheckT checkT;

    public void PrepareCheckTWhenProgramIsLoaded() 
    {
        LetseeMenuB.checkT = new CheckT();
    }

    public void ShowCheckTScreen() 
    {
        LetseeMenuB.checkT.Checkticket();
    }
   //---------------------------------------------//
    public void PrintMenuBScreen() {
        Console.Clear();
        PrintListMenuB();       
        PresentMenuB();
    }
    public void PrintListMenuB(){
        Console.WriteLine("/*************************/");
        Console.WriteLine("------Bus Ticket Booking----------");
        Console.WriteLine("1.Checking"); //ตารางเวลาวันนี้ รอบรถที่ จำนวนที่นั่ง  ?/25<0-24>  เช็คตัวเองจองหรือยัง
        Console.WriteLine("2.Booking");  //แสดงรอบรถปัจจุบัน จำนวนที่นั่ง  errorจากเเอด   เลือกให้จอด
        Console.WriteLine("4.Logout");
        Console.WriteLine("/*************************/");
    }

    public void PresentMenuB() 
    {
        Console.Write("Please input Menu:");
        int b1 = (int.Parse(Console.ReadLine()));
        switch(b1) 
        {
            case 1
                :PrepareCheckTWhenProgramIsLoaded();
                 ShowChecking();             
                break;
            case 2
                :PrepareBookTKmuttWhenProgramIsLoaded();
                 ShowBooking();                
                break;

            case 3
                :Console.WriteLine("Loginout...");
                //  Program.Menu();   หน้าเมนูของยี             
                break;   
            default:Console.WriteLine("Something went wrong, please try again.");
                    Console.WriteLine("Wait a sec....");
                    System.Threading.Thread.Sleep(2000);
                    PrintMenuBScreen();
                    
                break;
        }
    }
    //---------------------------------------------//

   public void ShowChecking(){
        Console.Clear();
        LetseeMenuB.checkT.PrinCheckTingScreen();
    }
    public void ShowBooking(){
        Console.Clear();
        
        LetseeMenuB.bookTkmutt.PrintBookingScreen();
    }

    
}