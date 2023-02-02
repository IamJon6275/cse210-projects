using System;

class Program
{
    static void Main(string[] args)
    {
        // _continue is set to true so the while loop can run once
        bool _continue = true;
        Journal j = new Journal();
        
        // Greet the user
        Console.WriteLine("Welcome to the Journal Program!");

        // While loop to call the different classes and loop the program until the user decides to quit
        while (_continue)
        {
            Menu m = new Menu();
            m.DisplayMenu();
            m._selector = int.Parse(Console.ReadLine());

            
            _continue = j.HandleJournal(m._selector);
        }
    }
}