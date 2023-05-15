class Registry{
    private bool hasDiscount;
    private List<Person> people;
    public int Price {get; set;}

    public Registry() //Constructor explicito
    {
        people = new List<Person>();
    }

    public void printAllPeople()
    {
        foreach(Person person in people)
        {
            Console.WriteLine(person.Name);
        }
    }

    public void addPerson(Person person)
    {
        people.Add(person);
    }

    public void discount(int value)
    {
        if (value == 1)
        {
            hasDiscount = true;
        }
        else
        {
            hasDiscount = false;
        }
    }

    public double calculateAndReturnPrice(int numberOfGuests, int daysOfStay)
    {
        double finalPrice;
        switch (numberOfGuests)
        {
            case 1:
                finalPrice = PricesDao.INDIVIDUAL_PRICE * daysOfStay * 1.19;
                finalPrice = hasDiscount ? finalPrice / 1.05 : finalPrice;
                break;
            case 2:
                finalPrice = PricesDao.DOUBLE_PRICE * daysOfStay * 1.19;
                finalPrice = hasDiscount ? finalPrice / 1.09 : finalPrice;
                break;
            default:
                finalPrice = PricesDao.FAMILIAR_PRICE * daysOfStay * 1.19;
                finalPrice = hasDiscount ? finalPrice / 1.15 : finalPrice;
                break;
        }

        return finalPrice;
    }
}