using G12_Collections;

IList<string> list = new MyList<string>();//+
MyStack<string> stack = new MyStack<string>();//+
MyQueue<string> queue = new MyQueue<string>();

list.Add("Daiana");
//stack.Add("Daiana");
//queue.Add("Daiana");

//queue.Enqueue("GOG");
//queue.Enqueue("Push");
//queue.Enqueue("Myman");
//queue.Enqueue("Itsgood");
//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}

list.Add("Man");
list.Add("Man1");
list.Add("Man2");
//list.RemoveAll("Man");


foreach (var item in list)
{
    Console.WriteLine(item);
}
//Console.WriteLine(GetSum(list));

//static void Print<T>(T[] items)
//{
//    T[] array = new T[10];
//    foreach (T item in items)
//    {
//        Console.WriteLine(item);
//    }
//}
//static int GetSum(MyList<int> array)
//{
//    int sum = 0;
//    for (int i = 0; i < array.Count; i++)
//    {
//        sum += array[i];
//    }
//    return sum;
//}

//stack.Push("GOG");
//stack.Push("Push");
//stack.Push("Myman");
//stack.Push("Itsgood");
//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}