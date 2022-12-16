namespace LinkedList
{
    public class Program
    {

        static void Main(string[] args)
        {
            Queue_Ex que = new Queue_Ex();
            que.Enqueue(10);
            que.Enqueue(20);
            que.Enqueue(30);
            que.Enqueue(40);
            que.Display();
            que.Dequeue();
            que.Display();
        }
    }
}