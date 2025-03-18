using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace ConApp01
{
    class Arraylistexample
    {
        static void Main()
        {
            ArrayList Operations = new ArrayList();

            int ch;
            do
            {
                Console.WriteLine("\n OPERATIONS,\n 1.Add an item.,\n 2.Display the items.,\n 3. Search an item., \n 4.Remove an item.\n 5. Update an item");
                Console.Write("\n Select the Operation to be perfomed : ");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Write("\nEnter an item to be added: ");
                        var Newitem = Console.ReadLine();
                        Operations.Add(Newitem);
                        Console.WriteLine($"\nThe item {Newitem} has been added to the list");
                        break;


                    case 2:
                        Console.WriteLine("\nThe list of the items available are");
                        Console.WriteLine("\n=====================================");
                        foreach (var item in Operations)
                            Console.WriteLine(item);
                        Console.WriteLine("=====================================");
                        break;

                    case 3:
                        Console.Write("\nEnter the item to be searched : ");
                        var search = Console.ReadLine();
                        bool status = Operations.Contains(search);
                        if (status)
                        {
                            Console.WriteLine($"\nThe Item {search} is found in the list");
                        }
                        else
                        {
                            Console.WriteLine("\nThe searched Item " + search + " is not found in the list");
                        }
                        break;

                    case 4:
                        Console.Write("\nEnter the item which needs to be deleted : ");
                        var RemoveItem = Console.ReadLine();
                        if (Operations.Contains(RemoveItem))
                        {
                            Operations.Remove(RemoveItem);
                            Console.WriteLine($"\nThe item {RemoveItem} has been delted");

                        }
                        else
                        {
                            Console.WriteLine($"\nThe item {RemoveItem} does not exist.");

                        }
                        break;

                    case 5:
                        Console.Write("\nEnter the item which needs to be updated : ");
                        var Updateitem = Console.ReadLine();
                        bool status2 = Operations.Contains(Updateitem);
                        if (status2)
                        {
                            int index = Operations.IndexOf(Updateitem);
                            Console.Write($"\nEnter the item to update {Updateitem} in the list :");
                            Newitem = Console.ReadLine();
                            Operations[index] = Newitem;
                            Console.WriteLine($"\nThe {Updateitem} has been updated to {Newitem} ");
                        }
                        else
                        {
                            Console.WriteLine($"\nThe {Updateitem} does not exits ");
                        }
                        break;


                } 







            } while (ch < 6);




        }

    }
}
