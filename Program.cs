using DSTALGOQueueApp;
using System.Diagnostics.Metrics;

CircularQueue<string> qLine = new CircularQueue<string>();
CircularQueue<string> qA = new CircularQueue<string>();
CircularQueue<string> qB = new CircularQueue<string>();

//Console.WriteLine("Bank Transaction Queuing System" +
//    "\n[1] - New Customer" +
//    "\n[2] - View All Customers" +
//    "\n[3] - Serve Next Customer @ Counter A" +
//    "\n[4] - Serve Next Customer @ Counter B" +
//    "\n[5] - View Customer Queuing Summary" +
//    "\n[x] - Quit");

for (int i = 0; i < 20; i++)
{
    Console.WriteLine("Bank Transaction Queuing System" +
    "\n[1] - New Customer" +
    "\n[2] - View All Customers" +
    "\n[3] - Serve Next Customer @ Counter A" +
    "\n[4] - Serve Next Customer @ Counter B" +
    "\n[5] - View Customer Queuing Summary" +
    "\n[x] - Quit");

    Console.Write("\nOperator's choice >> ");
    Console.ForegroundColor = ConsoleColor.Yellow;
    string choice = Console.ReadLine();
    Console.ForegroundColor = ConsoleColor.Gray;

    if (choice == "1")
    {
        Console.Write("Enter customer name: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string temp = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        qLine.Enqueue(temp);
        Console.WriteLine("Customer has been added to Queue.\n\nPress <Enter> to continue...");
        Console.ReadLine();
        Console.Clear();
    }
    else if (choice == "2")
    {
        Console.WriteLine("~~ Customers on Queue ~~");
        qLine.PrintQueue();
        Console.WriteLine("------------------------\n\nPress <Enter> to continue...");
        Console.ReadLine();
        Console.Clear();
    }
    else if (choice == "3")
    {
        string temp = qLine.Dequeue();
        qA.Enqueue(temp);
        Console.Write("Now Serving Customer ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(temp);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" @ Counter A\n\nPress <Enter> to continue...");
        Console.ReadLine();
        Console.Clear();
    }
    else if (choice == "4")
    {
        string temp = qLine.Dequeue();
        qB.Enqueue(temp);
        Console.Write("Now Serving Customer ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(temp);
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" @ Counter B\n\nPress <Enter> to continue...");
        Console.ReadLine();
        Console.Clear();
    }
    else if (choice == "5")
    {
        Console.WriteLine("~~ Customers Served at Counter A ~~");
        qA.PrintQueue();
        Console.WriteLine("------------------------\n");
        Console.WriteLine("~~ Customers Served at Counter B ~~");
        qB.PrintQueue();
        Console.WriteLine("------------------------\n");
        Console.WriteLine("~~ Remaining Customers on Queue ~~");
        qLine.PrintQueue();
        Console.WriteLine("------------------------\n\nPress < Enter > to continue...");
        Console.ReadLine();
        Console.Clear();
    }
    else if (choice == "x")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Are you sure you want to quit? [Y] or [N]: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string temp = Console.ReadLine();
        if (temp == "y" || temp == "Y")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nThank you for using our services!");
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        }
        else if (temp == "n" || temp == "N")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nYou may continue your transaction.");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\nPress <Enter> to continue...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}