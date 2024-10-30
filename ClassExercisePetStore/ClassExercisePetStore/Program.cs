Console.WriteLine("Press 1 to add a product");
Console.WriteLine("Type 'exit' to quit");

string userInput = Console.ReadLine();

while (userInput.ToLower() != "exit");
{
    userInput = Console.ReadLine();
    int userInputNumber = Convert.ToInt32(userInput);

    if (userInputNumber == 1)
    {
        Console.WriteLine("Come back later");
    }
    else
    {
        Console.WriteLine("Unvalid input. Please try again");
        
    }
}
