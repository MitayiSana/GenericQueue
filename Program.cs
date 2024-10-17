namespace GenericQueue
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            //Performaing enqueue...
            
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            Console.WriteLine("Enqueue............");
          
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            //Dequeue.......
            Console.WriteLine("Dequeue");
            var d =q.Dequeue();
            Console.WriteLine(d);
            
            
            
        }
    }
}
