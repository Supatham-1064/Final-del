class Get_Set_ticket{
    private int ticket=0;

    public void increase_ticket(){
        this.ticket++;
        if (ticket>25){
            Console.WriteLine("you cannot get ticket");
            Console.WriteLine("Ticket is out");
            ticket--;
        }
    }
    public void decrease_ticket(){
        this.ticket--;
        if (ticket <= -1){
            Console.WriteLine("you cannot cancle");
            ticket=0;
        }
    }
    public void reset_ticket(){
        this.ticket=0;
    }
    public int get_ticket(){
        return this.ticket;
    }
}