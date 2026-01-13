using LibraryStar;

Person person = new Person
{
    FirstName = "John",
    LastName = "Doe",
    DateOfBirth = new DateTime(1990,1,1)
};

Console.WriteLine(person);

Console.WriteLine("Enter Temperature in Celsiu: ");

String? celsiuString = Console.ReadLine();
if (double.TryParse(celsiuString, out double celsiu))
{
    double fahrenheit = (celsiu * 9 / 5) + 32;
    Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
}
else
{
    Console.WriteLine("Invalid input for temperature.");
}

