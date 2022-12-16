namespace LinkedList
{
    public class Program
    {

        static void Main(string[] args)
        {
            // Linkedlist list = new Linkedlist();
            // list.Addnode(10);
            //list.Addnode(20);
            //list.Addnode(30);
            //list.Display();
            // list.DeleteLast();
            //list.Display();
            Stack_Ex stack_ = new Stack_Ex();
            stack_.Push(10);
            stack_.Push(20);
            stack_.Push(30);
            stack_.Display();
            stack_.Pop();
            stack_.Display();

        }
    }
}
