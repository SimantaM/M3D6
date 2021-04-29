using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{

class Program
{
    public static Tuple<double, double> cal(double a, double b)
    {
        return new Tuple<double, double, double, double>((a+b),(a*b),(a-b),(a/b));
    }
    
    static void Main(string[] args)
    {
        Tuple<double, double, double, double> output = Program.cal(6,2);
        Console.WriteLine("Sum= "+output.Item1+" Multiplication value= "+output.Item2+" Difference= "+output.Item3+" Division value= "+output.Item4);
        Console.ReadLine();
    }
}
}


---------------------------------------------------------------------------------------------------------------------------------------------------------------------


using System.IO;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{

class Program
{
    public static void Main()
    {
        List<int> myList=new List<int>();
        for(int i=5;i<10;i++)
        {
            myList.Add(i*2);
        }
        
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}
}


----------------------------------------------------------------------------------------------------


using System.IO;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{

class Program
{
    public static void Main()
    {
        List<int> myList=new List<int>();
        for(int i=5; i<10; i++)
        {
            
               myList.Add(i);
        }
        
        foreach (var item in myList)
        {
            Console.WriteLine(item);
            if (item%2==0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
         
            
        }
        }
        Console.ReadLine();
    }
}
}

-----------------------------------------------------------------------------------------------------


using System.IO;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hello
{

class Program
{
    public static void Main()
    {
       
        Queue myqueue= new Queue();
        myqueue.Enqueue("C#");
        myqueue.Enqueue("PHP");
        myqueue.Enqueue("JAVA");
        myqueue.Enqueue("C");
        Console.WriteLine(myqueue.Count);
        Console.WriteLine(myqueue.Peek());
        
        foreach (var item in myqueue.ToArray())
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}
}


--------------------------------------------------------------------------------------


using System.IO;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hello
{

class Program
{
    public static void Main()
    {
        Dictionary<int, string> keyValuePairs= new Dictionary<int, string>();
        
        keyValuePairs.Add(1, "Simanta");
        keyValuePairs.Add(2, "John");
        keyValuePairs.Add(3, "William");
        Console.WriteLine(keyValuePairs[1]);
        foreach (var item in keyValuePairs)
        {
           Console.WriteLine("Key= "+item.Key+" Value= "+item.Value);
        }
        
        if (keyValuePairs.ContainsKey(1)==true)
        {
            Console.WriteLine("Key Found");
        }
        else
        {
            Console.WriteLine("Key Not Found");
        }
        
        if (keyValuePairs.ContainsValue("Simanta"))
        {
         Console.WriteLine("Value Found");
        }
        else
        {
            Console.WriteLine("Value Not Found");
        }   
        Console.ReadLine();
    }
}
}

-----------------------------------------------------------------------------------------


using System.IO;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hello
{

class Program
    {
        static void Main()
        {
            Dictionary<char, int> rep = new Dictionary<char, int>();
            Console.WriteLine("Enter a String : ");
            string word = Console.ReadLine();
            for (int i=0;i<word.Length;i++)
            {
                int count = 0;
                foreach (char c in word)
                {
                    if (c == word[i])
                    {
                        count++;
                    }
                }
                if (!rep.ContainsKey(word[i]))
                {
                    rep.Add(word[i], count);
                }
            }
            foreach (var item in rep)
            {
                Console.WriteLine("Key = " + item.Key + "; Value = " + item.Value);
            }
 
        }
    }
}


----------------------------------------------------------------------------------------------------------






