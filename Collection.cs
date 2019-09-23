using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections
{
    public class Collection
    {
        public static List<string> MakeList()
        {
            List<string> vs = new List<string>();
            foreach (string ship in new string[] 
            { "USS Enterprise", "Klingon Bird-of-Prey", "Borg Cube", "Romulan Warbird", "USS Stargazer" })
            {
                vs.Add(ship);
            }
            return vs;
        }
        public static void PrintList(List<string> ts)
        {
            Console.WriteLine("List of ships");
            foreach (var x in ts)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        
        public static LinkedList<string> MakeLinkedList()
        {
            LinkedList<string> vs = new LinkedList<string>();
            foreach (string location in new string[] 
            { "Bridge", "Transporter", "Holodeck", "Medical Bay", "Engineering Room" })
            {
                vs.AddFirst(location);
            }
            return vs;
        }
        public static void PrintLinkedList(LinkedList<string> ts)
        {
            Console.WriteLine("LinkedList of locations on the ship");
            foreach (var x in ts)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        public static Queue<string> MakeQueue()
        {
            Queue<string> vs = new Queue<string>();
            
            foreach (string character in new string[] 
            { "Captain Jean-Luc Picqard", "Commander William Riker", "Lt. Commander Data", "Lieutenant Worf", "Counselor Deanna Troi", "Dr. Beverly Crusher" })
            {
                vs.Enqueue(character);
            }
            return vs;
        }
        public static void PrintQueue(Queue<string> ts)
        {            
            Console.WriteLine("Queue of characters");
            foreach (var x in ts)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        
        public static Stack<string> MakeStack()
        {
            Stack<string> vs = new Stack<string>();
            foreach (string quote in new string[] 
            { "Engage.", "Make it so Number One.", "Resistance is futile.  You will be assimilated.", "Computer: Tea, Earl Grey, Hot.","Tell him he is a pretty cat, and a good cat." })
            {
                vs.Push(quote);
            }
            return vs;
        }
        public static void PrintStack(Stack<string> ts)
        {
            Console.WriteLine("Stack of great quotes");
            foreach (var x in ts)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("\n");
        }
        
        public static Dictionary<string, char> MakeDictionary()
        {
            Dictionary<string, char> keyValuePairs = new Dictionary<string, char>()
            {
                ["Captain Jean-Luc Picqard"] = 'p',
                ["Commander William Riker"] = 'r',
                ["Lt. Commander Data"] = 'd',
                ["Lieutenant Worf"] = 'w',
                ["Counselor Deanna Troi"] = 't',
                ["Dr. Beverly Crusher"] = 'c'
                
            };
            return keyValuePairs;
        }
        public static void PrintDictionary(Dictionary<string, char> keyValuePairs)
        {
            Console.WriteLine("Dictionary of characters");
            foreach (KeyValuePair<string, char> element in keyValuePairs)
            {
                string person = element.Key;
                char firstInitial = element.Value;
                Console.WriteLine($"The character {person}'s first initial is '{firstInitial}'");
            }
            Console.WriteLine("\n");
        }
        public static SortedList<int, string> MakeSortedList()
        {
            SortedList<int, string> keyValuePairs = new SortedList<int, string>()
            {
                {5, "frontier." },
                {1, "Space" },
                {3, "The " },
                {4, "final " },                
                {2, ".  " }
            };
            return keyValuePairs;
        }
        public static void PrintSortedList(SortedList<int, string> keyValuePairs)
        {
            Console.WriteLine("Sorted list of the opening line");
            foreach (KeyValuePair<int, string> element in keyValuePairs)
            {
                double number = element.Key;
                string word = element.Value;
                Console.Write(word);
            }
            Console.WriteLine("\n");
        }
        public static void RunAllPrintMethods()
        {
            PrintList(MakeList());
            PrintLinkedList(MakeLinkedList());
            PrintQueue(MakeQueue());
            PrintStack(MakeStack());
            PrintDictionary(MakeDictionary());
            PrintSortedList(MakeSortedList());
        }

    }
}
