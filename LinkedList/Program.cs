namespace LinkedList
{
    public class Program
    {

        static void Main(string[] args)
        {
            Linkedlist list = new Linkedlist();
            list.Addnode(10);
            list.Addnode(20);
            list.Addnode(30);
            list.Display();
            list.DeleteLast();
            list.Display();



        }
    }
}