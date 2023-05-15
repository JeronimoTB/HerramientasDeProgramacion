// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


List<Registry> registries = new List<Registry>();
while (true)
{
    Console.WriteLine("What do you want to do?\n0. Exit\n1. New registry\n2. See all registries");
    int optionOne = Int32.Parse(Console.ReadLine());

    if (optionOne == 0)
    {
        Console.WriteLine("Good bye!!");
        break;
    }
    else if (optionOne == 1)
    {
        int numberOfGuests; 
        do
        {
            Console.WriteLine("How many people?");
            numberOfGuests = Int32.Parse(Console.ReadLine());
        } while (numberOfGuests > 3);

        Console.WriteLine("Does it have discount? Put 1 for yes and 0 for no");
        int optionThree = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Days of stay");
        int daysOfStay = Int32.Parse(Console.ReadLine());

        Registry registry = new Registry();
        registries.Add(registry);

        registry.discount(optionThree);
        double finalPrice;

        for (int i = 0; i < numberOfGuests; i++)
        {
            Console.WriteLine("Give me the name of the " + (i + 1) + " guest");
            string name = Console.ReadLine();
            Person person = new Person(name);

            registry.addPerson(person);
        }

        finalPrice = registry.calculateAndReturnPrice(numberOfGuests, daysOfStay);
        Console.WriteLine("This is the price for the room: " + finalPrice);

    }
    else if (optionOne == 2)
    {
        if (registries.Count < 1)
        {
            Console.WriteLine("There's no registries yet");                
        }
        foreach(Registry registry in registries)
        {
            Console.WriteLine("We have the following guests in this room:");
            registry.printAllPeople();
        }
    }
    else
    {
        Console.WriteLine("What?? Read! For gods sake!!");
    }
}