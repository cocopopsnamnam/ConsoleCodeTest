namespace Threading 
{
    public class Program
    {
        public List<string> myList = new List<string>();
        public SemaphoreSlim gate = new SemaphoreSlim(3);
        public string[] listOfStrings = { "Lorem ", "ipsum ", "dolor ", "sit ", "amet", "consectetur ", "adipiscing ", "elit",
            "sed", "id", "Lorem ", "ipsum ", "dolor ", "sit ", "amet", "consectetur ", "adipiscing ", "elit", "sed", "id" };

        public void Main()
        {
            myList.AddRange(listOfStrings);
        

            Task[] tasks = new Task[3];
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    tasks[i].Run(() =>
                    {
                        gate.Wait();
                        IterateList();
                    });
                }
            }
            finally
            {
                gate.Release(3);
            }
            
        }

        public Task IterateList()
        {
            try
            {
                for (int i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine(myList[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}