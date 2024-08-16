public class Program
{
    public static void Main()
    {
        List<string> coffee = new List<string>(); // Creating named coffee and string type list object
       

        Console.Write("Kahve isimleri:\n"); // Title
        Console.WriteLine();

        int i = 0;
        while (true) 
        {

            Console.Write($"Kahve ismi {i + 1}: ");
            i++;
            string userResponse = Console.ReadLine(); // Get user input

            coffee.Add(userResponse); // Add written items to list

            if (coffee.Count == 5) // Number of coffee names can be 5
            {
                break; // break the loop
            }

            

        }


        Console.WriteLine("-----------------\nKahve Listesi:");
        foreach (string item in coffee) // Print the list
        {
            Console.WriteLine(item);
        }


    }
}
