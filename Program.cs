using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node Start = new Node();
            Start.Data = -1;
            Node Next = new Node();
            Next = null;
            Start.Point =  Next;
            int Choice;

            while(true)
            {
                Console.WriteLine("Press 1 to insert 2 to print all");
                Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice){
                    case 1:
                        if(Start.Data == -1)
                        {
                            Start.Data = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            Next = new Node();
                            Next = Start;
                            Start = new Node();
                            Start.Data = Convert.ToInt32(Console.ReadLine());
                            Start.Point = Next;
                        }
                    break;
                    case 2:
                        Node Temp = Start;
                        while(Temp != null)
                            {
                                Console.WriteLine(Temp.Data);
                                Temp = Temp.Point;
                            }
                    break;

                    default:
                     Console.WriteLine("Invalid Input");
                     break;
                }
            }
            
        }
    }

    class Node
    {
        public int Data;
        public Node Point = null;
    }
}
