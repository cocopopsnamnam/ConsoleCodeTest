using System.Text.Json;

namespace API
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ApiConnectionHelper.InitializeConnection();
            PeopleProcessor peopleProcess = new PeopleProcessor();
            string initialUserInput = "";

            Console.WriteLine("Input number ID");
            initialUserInput = Console.ReadLine();

            if (Int32.TryParse(initialUserInput, out int j))
            {
                People foundPeople = await peopleProcess.LoadPeopleFromApi(j);
                string jsonString = JsonSerializer.Serialize(foundPeople);
                Console.WriteLine(jsonString);
            }
            else
            {
                Console.WriteLine("String could not be parsed.");
            }
        }
    }
}

