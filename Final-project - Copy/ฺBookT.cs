class BookTKmutt {
    static LetseeMenuB letseemenuB;
    
    
    LinkedListB<char> Book_KmuttGKon = new LinkedListB<char>();
    LinkedListB<char> Book_KhunGkmutt = new LinkedListB<char>(); 


    public void PrepareMenuBWhenProgramIsLoaded() 
    {
        BookTKmutt.letseemenuB = new LetseeMenuB();
    }

    public void ShowMainMenuBScreen() 
    {
        BookTKmutt.letseemenuB.PrintMenuBScreen();
    }
    
    public void PrintBookingScreen() {
        Console.Clear();
      
        BookKmuttticket();
        PresentBookTKmutt();        
        
    }

    public void BookKmuttticket(){
        Console.WriteLine("*----------------------------*");
        Console.WriteLine("*-Time*");              //ตารางเวลา----
        Console.WriteLine("*--------Book_Ticket---------*");
        Console.WriteLine("*1.KMUTT --> Bang Khun Thian *");
        Console.WriteLine("*2.Bang Khun Thian --> KMUTT *");
        Console.WriteLine("*3.Back to Bus Ticket Booking*");
        Console.WriteLine("/****************************/");
        
    }
    public void PresentBookTKmutt(){
        Console.Write("Please input Menu:");
        int b1 = (int.Parse(Console.ReadLine()));
        switch(b1) 
        {
            case 1
                :ShowBookK_B();
                 PutppkmuttT();
                break;
            case 2
                :
                 ShowBookB_K();
                 PutppkhonT();                
                break;
            case 3
                :
                PrepareMenuBWhenProgramIsLoaded();
                Console.Clear();
                Console.WriteLine("Back to Mainmenu.");
                Console.WriteLine("Wait a sec....");
                System.Threading.Thread.Sleep(3000);
                ShowMainMenuBScreen();        
                break;   
            default:Console.WriteLine("Something went wrong, please try again.");
                    Console.WriteLine("Wait a sec....");
                    System.Threading.Thread.Sleep(2000);
                    PrintBookingScreen();
                    
                break;
        }

    }
    public void ShowBookK_B(){ 
        
        Console.Clear();      
        Console.WriteLine("*-----------------------------*");
        Console.WriteLine("*Time----*");                         //ตารางเวลา----
        Console.WriteLine("*remaining seats {0}/25*",Book_KmuttGKon.GetLength());             //ที่นั่งที่เหลือ----
        Console.WriteLine("*--------Book_Ticket----------*");
        Console.WriteLine("*--KMUTT --> Bang Khun Thian--*");
        Console.WriteLine("*Book pls input [Y]");
        Console.WriteLine("*Back pls input [?]*");
        Console.WriteLine("/*****************************/");

    }
   

    public void PutppkmuttT(){
        Console.Write("Please input Menu:");
        
        int range_KmuttGKon = Book_KmuttGKon.GetLength()-1;
        char KM_KON = char.Parse(Console.ReadLine());

        if((KM_KON == 'Y')||(KM_KON == 'y'))
        {
            Book_KmuttGKon.Add('G');
            Console.Clear();
            if(range_KmuttGKon > 24)
            {
              
              Console.WriteLine("Tickets are full.Please check next.");
              Book_KmuttGKon.Remove(range_KmuttGKon);
            }
            else{
            Console.WriteLine("Booking bus Kmutt->Bang Khon complete.");
            Console.WriteLine("Save....");
            System.Threading.Thread.Sleep(3000);
            }
            
            
        }
        else if(KM_KON == '?'){
            Console.Clear();
            Console.WriteLine("Back to around the bus ticket.");
            Console.WriteLine("Wait a sec....");
            System.Threading.Thread.Sleep(3000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Error input.");
            Console.WriteLine("Back to around the bus ticket.");
            Console.WriteLine("Wait a sec....");
            System.Threading.Thread.Sleep(3000);
        }
        PrintBookingScreen();
       

    }

    

    public void ShowBookB_K(){ 

        Console.Clear();    
        Console.WriteLine("*-----------------------------*");
        Console.WriteLine("*Time----*");                         //ตารางเวลา----
        Console.WriteLine("*remaining seats {0}/25*",Book_KhunGkmutt.GetLength());             //ที่นั่งที่เหลือ----
        Console.WriteLine("*--------Book_Ticket----------*");
        Console.WriteLine("*--Bang Khun Thian --> KMUTT--*");
        Console.WriteLine("*Book pls input [Y]");
        Console.WriteLine("*Back pls input [?]*");
        Console.WriteLine("/*****************************/");

    }


    public void PutppkhonT(){
        Console.Write("Please input Menu:");
        
        int range_KhunGkmutt = Book_KhunGkmutt.GetLength()-1;
        char KON_KM = char.Parse(Console.ReadLine());

        if((KON_KM == 'Y')||(KON_KM == 'y'))
        {
            Book_KhunGkmutt.Add('B');
            
            Console.Clear();
            if(range_KhunGkmutt > 24)
            {
              
              Console.WriteLine("Tickets are full.Please check next.");
              Book_KhunGkmutt.Remove(range_KhunGkmutt);
              System.Threading.Thread.Sleep(3000);
            }
            else {           
              Console.WriteLine("Booking bus Bang Khon->Kmutt complete.");
              Console.WriteLine("Save....");
              System.Threading.Thread.Sleep(3000);
            }
            
        }
        else if(KON_KM == '?'){
            Console.Clear();
            Console.WriteLine("Back to around the bus ticket.");
            Console.WriteLine("Wait a sec....");
            System.Threading.Thread.Sleep(3000);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Error input.");
            Console.WriteLine("Back to around the bus ticket.");
            Console.WriteLine("Wait a sec....");
            System.Threading.Thread.Sleep(3000);
        }
        
        
        PrintBookingScreen();
       

    }
}