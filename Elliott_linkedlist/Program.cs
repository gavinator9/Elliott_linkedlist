// Gavin Elliott
// IT113
// NOTES: This was easier than I thought, but then again you did spoon feed us the ins and outs of linked lists so thanks for that
// BEHAVIORS NOT IMPLIMENTED AND WHY: N/A as far as I can see!
using System.Runtime.CompilerServices;

namespace Elliott_linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            linkedlist ll= new linkedlist();
            ll.add("jotho");
            ll.add("zorbo");
            ll.add("Aflack");
            ll.add("Xavier");
            ll.add("Aaron");
            bool running = true;
            while (running == true)
            {


                Console.WriteLine("Welcome to the linked list of names\n");
                Console.WriteLine("1: Add Item");
                Console.WriteLine("2: Remove Item");
                Console.WriteLine("3: Search for item");
                Console.WriteLine("4: Print");
                Console.WriteLine("5: Exit");
                string input;
                input=Console.ReadLine();
                if (input == "1")
                {
                    Console.WriteLine("\n Enter your first name and it will be automagically added");
                    string name= Console.ReadLine();
                    ll.add(name);
                    Console.WriteLine("Name added to list!");
                }
                if (input == "2")
                {
                    Console.WriteLine("Please input the name you want kicked outta here");
                    string name= Console.ReadLine();
                    bool result=ll.remove(name);
                    if (result==true)
                    {
                        Console.WriteLine("We got rid of em boss");
                    }
                    else
                    {
                        Console.WriteLine("No such guy boss");
                    }
                }
                if (input == "3")
                {
                    Console.WriteLine("What name are we searching for?");
                    string name= Console.ReadLine();
                    node temp=ll.contains(name);
                    if (temp!=null)
                    {
                        Console.WriteLine("Exact match found!");
                    }
                    else { Console.WriteLine("No match found"); }

                }
                if (input == "4")
                {
                    ll.printallnodes();
                }
                if (input == "5")
                {
                    running= false;
                }
            }

        }
    }
}