using ClassExercisePetStore;
using System.Text.Json;

var productLogic = new ProductLogic();
string userInput;
do
{

    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type 'exit' to quit");

    userInput = Console.ReadLine();

    if (userInput == "1")
    {
        Console.WriteLine("1: Cat Food");
        Console.WriteLine("2: Dog Leash");
        Console.WriteLine("Enter product option:");
        string input = Console.ReadLine();
        Product product = null;

        if (input == "1")
        {
            product = new Product { Name = "Cat Food" };
        }
        else if (input == "2")
        {
            product = new Product { Name = "Dog Leash" };
        }
        else
        {
            Console.WriteLine("Invalid option.");
            continue;
        }
        productLogic.AddProduct(product);
        Console.WriteLine("Product added.");
    }
    else if (userInput.ToLower() != "exit") ;


    else
    {
        Console.WriteLine("Invalid input. Please try again");

    }
}
while (userInput.ToLower() != "exit");


var allProducts = productLogic.GetAllProducts();
Console.WriteLine("Products in store: ");
Console.WriteLine(JsonSerializer.Serialize(allProducts, new JsonSerializerOptions { WriteIndented = true }));