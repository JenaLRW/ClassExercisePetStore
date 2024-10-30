string userInput;
do
{

    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");

        userInput = Console.ReadLine(); // no prompt here. fix. 
    //int userInputNumber = Convert.ToInt32(userInput);  IF NEED TO CHANGE USERINPUT FROM STRING TO INT

    if (userInput == "1")
    {
        Console.WriteLine("1: Cat Food");
        Console.WriteLine("2: Dog Leash");
        Console.WriteLine("Enter product option:");
        string input = Console.ReadLine();

        // put code here to read input and go to next step.  input puts in an option 1 or 2 then get product name, price, etc etc
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again");

    }
}
while (userInput.ToLower() != "exit");