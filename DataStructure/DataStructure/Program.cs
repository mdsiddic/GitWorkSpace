using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n/*linked List*/");
            printLinkedList();

            Console.WriteLine("\n/*reverse the sentence in the word*/");
            Console.WriteLine(getReverseSentence("Reverse order of sentence"));

            Console.WriteLine("\n/*reverse the string*/");
            Console.WriteLine(getReverseString("Hello"));

            Console.WriteLine("\n/*remove duplicates in words (or) sorted/unsorted Array*/");
            Console.WriteLine(removeDuplicateSentence("duplicate is the duplicate remove the duplicate"));

            Console.WriteLine("\n/*remove duplicates in words*/");
            Console.WriteLine(removeDuplicateWords("duplicatewords"));

            Console.WriteLine("\n/*Push/Pop stack*/");
            var stackVal = pushStack();
            foreach(int i in stackVal)
            {
                Console.WriteLine(i.ToString());
            }
            
            int countStack = stackVal.Count;
            for (int i=0; i< countStack; i++)
            {
                Console.WriteLine(stackVal.Pop().ToString());
            }
            //LIFO, stack.Peek(),stack.Clear()

            Console.WriteLine("\n/*Queue*/");
            var queueVal = EnqueueQueue();
            foreach (int i in queueVal)
            {
                Console.WriteLine(i.ToString());
            }

            var countQueue = queueVal.Count();
            for(int i = 0; i < countQueue; i++)
            {
                Console.WriteLine(queueVal.Dequeue().ToString());
            }

            //stop the command prompt.
            Console.ReadLine();
        }

        private static void printLinkedList()
        {
            var lstrankData = new LinkedList<string>();
            lstrankData.AddFirst("First");
            lstrankData.AddLast("second");
            lstrankData.AddLast("four");
            var node = lstrankData.Find("four");
            lstrankData.AddBefore(node, "third");

            foreach (string lstData in lstrankData)
            {
                Console.WriteLine(lstData);
            }
        }

        private static string getReverseSentence(string sentenceOfWords)
        {
            return string.Join(" ", sentenceOfWords.Split(' ').Reverse().ToArray());
        }

        private static string getReverseString(string stringsOfWords)
        {
            var charArray = stringsOfWords.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static string removeDuplicateSentence(string duplicateSentence)
        {
            return string.Join(" ", duplicateSentence.Split(' ').Distinct());
        }

        private static string removeDuplicateWords(string duplicateWords)
        {
            var charArray = duplicateWords.ToCharArray();
            return string.Join("",charArray.Distinct());
        }

        private static Stack<int> pushStack()
        {
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < 7; i++)
            {               
                stack.Push(i);
            }
            return stack;
        }

        private static void popStack(Stack<int> stackValue )
        {            
            foreach(int i in stackValue)
            {
                Console.WriteLine(stackValue.Pop().ToString());
            }            
        }

        private static Queue<int> EnqueueQueue()
        {
            Queue<int> enqueue = new Queue<int>();
            enqueue.Enqueue(1);
            enqueue.Enqueue(2);
            enqueue.Enqueue(3);

            return enqueue;
        }
    }
}
