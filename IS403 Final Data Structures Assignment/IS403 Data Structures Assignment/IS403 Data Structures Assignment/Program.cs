//test

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS403_Data_Structures_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endprogram = false;

            while (endprogram == false)
            {
                //***Main Menu***
                Console.WriteLine("1. Stack \n2. Queue \n3. Dictionary \n4. Exit");
                string mainmenuchoice;
                mainmenuchoice = Console.ReadLine();

                //***Stack***
                if (mainmenuchoice == "1")
                {
                    //create blank stack
                    Stack<string> myStack = new Stack<string>();

                    bool endmenu1 = false;

                    while (endmenu1 == false)
                    {
                        Console.WriteLine("1. Add one time to Stack \n2. Add Huge List of Items to Stack \n3. Display Stack \n4. Delete from Stack \n5. Clear Stack \n6. Search Stack \n7. Return to Main Menu");
                        string menu1choice;
                        menu1choice = Console.ReadLine();

                        //Add one item to Stack
                        if (menu1choice == "1")
                        {
                            //read in user input
                            Console.WriteLine("Please enter stack item");
                            string stackitem = Console.ReadLine();

                            //add user input item to Stack
                            myStack.Push(stackitem);
                        }
                        //Add huge lits to Stack - first deletes stack, then adds 2,000 "New Entry" items
                        if (menu1choice == "2")
                        {
                            //clears the stack
                            myStack.Clear();
                            for (int i = 0; i < 2000; i++)
                            {
                                myStack.Push("New Entry " + (i + 1));
                            }
                        }
                        //Display Stack
                        if (menu1choice == "3")
                        {
                            //Tell user if stack is empty
                            if (myStack.Count == 0)
                            {
                                Console.WriteLine("The Stack is empty");
                            }
                            else
                            {
                                foreach (string value in myStack)
                                {
                                    Console.WriteLine(value);
                                }
                            }
                        }
                        //Delete from Stack
                        if (menu1choice == "4")
                        {
                            if (myStack.Count == 0)
                            {
                                Console.WriteLine("The Stack is empty");
                            }
                            //prompt for which item to delete
                            else
                            {
                                Console.WriteLine("Which item would you like to delete?");
                                string deleteitem = Console.ReadLine();

                                bool stackitemfound = false;

                                //Finds item.  If not item, pushes onto tempStack.  If item, pops from list.
                                Stack<string> temp = new Stack<string>(); //create a temp stack to save items not deleted
                                foreach (string value in myStack)
                                {
                                    //if not delete item, add to temp stack
                                    if (value != deleteitem)
                                    {
                                        temp.Push(value);
                                    }
                                    //if stack item found, change bool to true so error does not occur
                                    else
                                    {
                                        stackitemfound = true;
                                    }
                                }

                                //copy temp stack back into original stack
                                myStack.Clear(); //clear original stack first
                                foreach (string item in temp)
                                {
                                    myStack.Push(item);
                                }
                                //if delete item not found in list, tell the user
                                if (stackitemfound == false)
                                {
                                    Console.WriteLine("The item was not found.");
                                }
                            }
                        }
                        //Clear Stack
                        if (menu1choice == "5")
                        {
                            myStack.Clear();
                        }
                        //Search Stack (finds item in stack and returns time it took to find it.
                        if (menu1choice == "6")
                        {
                            if (myStack.Count == 0)
                            {
                                Console.WriteLine("The Queue is empty");
                            }
                            else
                            {
                                Console.WriteLine("Which item would you like to search for?");
                                string searchitem = Console.ReadLine();

                                //Create Stopwatch
                                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

                                //Searches for item and pushes all into tempStack.
                                bool searchitemfound = false;
                                Stack<string> temp = new Stack<string>(); //create a temp stack to save items while searching
                                
                                //Start StopWatch
                                sw.Start();
                                foreach (string value in myStack)
                                {
                                    if (value == searchitem)
                                    {
                                        //stop stopwatch
                                        sw.Stop();
                                        searchitemfound = true;
                                        //stopwatch returns time it took to find item
                                        Console.WriteLine("Time it took to search: " + sw.Elapsed);
                                    }
                                    temp.Push(value);
                                }
                                //tell user if stack item NOT found
                                if (searchitemfound == false)
                                {
                                    Console.WriteLine("Item was not found.");
                                }

                                //copy temp stack back into original stack
                                myStack.Clear(); //clear original stack first
                                foreach (string item in temp)
                                {
                                    myStack.Push(item);
                                }
                            }
                        }
                        //Return to Main Menu
                        if (menu1choice == "7")
                        {
                            endmenu1 = true;
                        }
                        //if user did not enter in valid menu choice
                        if (menu1choice != "1" & menu1choice != "2" & menu1choice != "3" & menu1choice != "4" & menu1choice != "5" & menu1choice != "6" & menu1choice != "7")
                        {
                            Console.WriteLine("Please enter a valid menu choice");
                        }
                    }
                }







                //***Queue***
                if (mainmenuchoice == "2") 
                {
                    //create blank queue
                    Queue<string> myQueue = new Queue<string>();

                    bool endmenu2 = false;

                    while (endmenu2 == false)
                    {
                        Console.WriteLine("1. Add one time to Queue \n2. Add Huge List of Items to Queue \n3. Display Queue \n4. Delete from Queue \n5. Clear Queue \n6. Search Queue \n7. Return to Main Menu");
                        string menu2choice;
                        menu2choice = Console.ReadLine();

                        //Add one item to Queue
                        if (menu2choice == "1")
                        {
                            //read in user input
                            Console.WriteLine("Please enter Queue item");
                            string queueitem = Console.ReadLine();

                            //add user input item to Queue
                            myQueue.Enqueue(queueitem);
                        }
                        //Add huge lits to Queue - first deletes queue, then adds 2,000 "New Entry" items
                        if (menu2choice == "2")
                        {
                            //clears the queue
                            myQueue.Clear();
                            for (int i = 0; i < 2000; i++)
                            {
                                myQueue.Enqueue("New Entry " + (i + 1));
                            }
                        }
                        //Display Queue
                        if (menu2choice == "3")
                        {
                            //Tell user if Queue is empty
                            if (myQueue.Count == 0)
                            {
                                Console.WriteLine("The Queue is empty");
                            }
                            else
                            {
                                foreach (string value in myQueue)
                                {
                                    Console.WriteLine(value);
                                }
                            }
                        }
                        //Delete from Queue
                        if (menu2choice == "4")
                        {
                            if (myQueue.Count == 0)
                            {
                                Console.WriteLine("The Queue is empty");
                            }
                            //prompt for which item to delete
                            else
                            {
                                Console.WriteLine("Which item would you like to delete?");
                                string deleteitem = Console.ReadLine();

                                bool Queueitemfound = false;

                                //Finds item.  If not item, pushes onto tempQueue.  If item, dequeue from list.
                                Queue<string> temp = new Queue<string>(); //create a temp stack to save items not deleted
                                foreach (string value in myQueue)
                                {
                                    //if not delete item, add to temp queue
                                    if (value != deleteitem)
                                    {
                                        temp.Enqueue(value);
                                    }
                                    //if stack item found, change bool to true so error does not occur
                                    else
                                    {
                                        Queueitemfound = true;
                                    }
                                }

                                //copy temp stack back into original stack
                                myQueue.Clear(); //clear original stack first
                                foreach (string item in temp)
                                {
                                    myQueue.Enqueue(item);
                                }
                                //if delete item not found in list, tell the user
                                if (Queueitemfound == false)
                                {
                                    Console.WriteLine("The item was not found.");
                                }
                            }
                        }
                        //Clear Queue
                        if (menu2choice == "5")
                        {
                            myQueue.Clear();
                        }
                        //Search Queue (finds item in queue and returns time it took to find it.
                        if (menu2choice == "6")
                        {
                            if (myQueue.Count == 0)
                            {
                                Console.WriteLine("The Queue is empty");
                            }
                            else
                            {
                                Console.WriteLine("Which item would you like to search for?");
                                string searchitem = Console.ReadLine();

                                //Create Stopwatch
                                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

                                //Searches for item and pushes all into tempQueue.
                                bool searchitemfound = false;
                                Queue<string> temp = new Queue<string>(); //create a temp queue to save items while searching

                                //Start Stopwatch
                                sw.Start();
                                foreach (string value in myQueue)
                                {
                                    if (value == searchitem)
                                    {
                                        //stop stopwatch
                                        sw.Stop();
                                        searchitemfound = true;
                                        //stopwatch returns time it took to find item
                                        Console.WriteLine("Time it took to search: " + sw.Elapsed);
                                    }
                                    temp.Enqueue(value);
                                }
                                //tell user if stack item NOT found
                                if (searchitemfound == false)
                                {
                                    Console.WriteLine("Item was not found.");
                                }

                                //copy temp stack back into original stack
                                myQueue.Clear(); //clear original stack first
                                foreach (string item in temp)
                                {
                                    myQueue.Enqueue(item);
                                }
                            }
                        }
                        //Return to Main Menu
                        if (menu2choice == "7")
                        {
                            endmenu2 = true;
                        }
                        //if user did not enter in valid menu choice
                        if (menu2choice != "1" & menu2choice != "2" & menu2choice != "3" & menu2choice != "4" & menu2choice != "5" & menu2choice != "6" & menu2choice != "7")
                        {
                            Console.WriteLine("Please enter a valid menu choice");
                        }
                    }
                }









                //***Dictionary***
                if (mainmenuchoice == "3")
                {
                    //create blank dictionary
                    Dictionary<string, int> myDictionary = new Dictionary<string, int>();

                    bool endmenu3 = false;

                    while (endmenu3 == false)
                    {
                        Console.WriteLine("1. Add one time to Dictionary \n2. Add Huge List of Items to Dictionary \n3. Display Dictionary \n4. Delete from Dictionary \n5. Clear Dictionary \n6. Search Dictionary \n7. Return to Main Menu");
                        string menu3choice;
                        menu3choice = Console.ReadLine();

                        //Add one item to Dictionary
                        if (menu3choice == "1")
                        {
                            //read in user input
                            Console.WriteLine("Please enter Dictionary string");
                            string dictionaryitem = Console.ReadLine();

                            bool inputInt = false;
                            int dictionaryint = 0;
                            while (inputInt == false)
                            {
                                Console.WriteLine("Please enter Dictionary int");
                                string dictionaryintstring = Console.ReadLine();
                                try
                                {
                                    dictionaryint = Convert.ToInt32(dictionaryintstring);
                                    inputInt = true;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Please enter a valid integer.");
                                    inputInt = false;
                                }
                            }

                            //add user input item to Queue
                            myDictionary.Add(dictionaryitem, dictionaryint);
                        }
                        //Add huge lits to Dictionary - first deletes dictionary, then adds 2,000 "New Entry" items
                        if (menu3choice == "2")
                        {
                            //clears the queue
                            myDictionary.Clear();
                            for (int i = 0; i < 2000; i++)
                            {
                                myDictionary.Add("New Entry " + (i + 1), (i + 1));
                            }
                        }
                        //Display Dictionary
                        if (menu3choice == "3")
                        {
                            //Tell user if Queue is empty
                            if (myDictionary.Count == 0)
                            {
                                Console.WriteLine("The Dictionary is empty");
                            }
                            else
                            {
                                foreach (KeyValuePair<string, int> value in myDictionary)
                                {
                                    Console.WriteLine(value.Key + " " + value.Value);
                                }
                            }
                        }
                        //Delete from Dictionary
                        if (menu3choice == "4")
                        {
                            if (myDictionary.Count == 0)
                            {
                                Console.WriteLine("The Dictionary is empty");
                            }
                            //prompt for which item to delete
                            else
                            {
                                Console.WriteLine("Which item would you like to delete?");
                                string deleteitemkey = Console.ReadLine();

                                if (myDictionary.ContainsKey(deleteitemkey))
                                {
                                    //Finds and deletes item from dictionary.
                                    myDictionary.Remove(deleteitemkey);
                                }
                                else
                                {
                                    Console.WriteLine("The item was not found.");
                                }
                            }
                        }
                        //Clear Dictionary
                        if (menu3choice == "5")
                        {
                            myDictionary.Clear();
                        }
                        //Search Dictionary (finds item in dictionary and returns time it took to find it.
                        if (menu3choice == "6")
                        {
                            if (myDictionary.Count == 0)
                            {
                                Console.WriteLine("The Dictionary is empty");
                            }
                            else
                            {
                                Console.WriteLine("Which item would you like to search for?");
                                string searchitem = Console.ReadLine();

                                //Create Stopwatch
                                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                                sw.Start();
                                bool searchitemfound = false;

                                //Searches for item and pushes all into tempQueue.
                                if (myDictionary.ContainsKey(searchitem))
                                {
                                    //stop stopwatch
                                    sw.Stop();
                                    searchitemfound = true;
                                    //stopwatch returns time it took to find item
                                    Console.WriteLine("Time it took to search: " + sw.Elapsed);
                                }
                                //tell user if stack item NOT found
                                if (searchitemfound == false)
                                {
                                    Console.WriteLine("Item was not found.");
                                }
                            }
                        }
                        //Return to Main Menu
                        if (menu3choice == "7")
                        {
                            endmenu3 = true;
                        }
                        //if user did not enter in valid menu choice
                        if (menu3choice != "1" & menu3choice != "2" & menu3choice != "3" & menu3choice != "4" & menu3choice != "5" & menu3choice != "6" & menu3choice != "7")
                        {
                            Console.WriteLine("Please enter a valid menu choice");
                        }
                    }
                }


                //***If user inputs invalid Main Menu choice***
                if (mainmenuchoice != "1" & mainmenuchoice != "2" & mainmenuchoice != "3" & mainmenuchoice != "4")
                {
                    Console.WriteLine("Please enter a valid Main Menu choice.");
                }
                //***Exit Program
                if (mainmenuchoice == "4")
                {
                    endprogram = true;
                }

            }

        }

    }
}

