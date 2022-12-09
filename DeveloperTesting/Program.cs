
using DeveloperTesting;
using DeveloperTesting.Database;



Family family = new Family();

int numbers;
Console.WriteLine("\nC#DeveloperTesting\n");
Console.WriteLine("1.Create a .NET console application to random a number from 1000 until the random number equal to zero. Each time the random number should less than the previous number.");
Console.WriteLine("2.From given example, how many time that this application tricker a query from database.");
Console.WriteLine("3.Design a database as a model in .NET project to store this data.");
Console.WriteLine("4.Create search function that query from above question can display the seniority from older to younger by input the name by using C# Console Application.");
Console.WriteLine("5.Create search function that query from above question can display the seniority from younger to older by input the name by using C# Console Application.");
Console.Write("Enter Number 1-5 : ");

int.TryParse(Console.ReadLine(), out numbers);

if(numbers == 1)
{
    RandomNumber random = new RandomNumber();
    random.RuningRandom();
    
}
else if (numbers == 2)
{
    Console.WriteLine("Table Customers are called once.");
}
else if (numbers == 3)
{
    Console.WriteLine("The script database file has been attached to the email.");
}

else if (numbers == 4)
{
    Console.Write("Enter Name : ");
    string name4 =  Console.ReadLine();
    family.OlderToYounger(name4);
}
else if (numbers == 5)
{
    Console.Write("Enter Name :");
    string name5 = Console.ReadLine();
    family.YoungerToOlder(name5);
}
else
{
   
    Console.WriteLine("Enter Number 1-5 ");
    
}

Console.ReadKey();

