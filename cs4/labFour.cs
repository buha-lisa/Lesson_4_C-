namespace cs4
{
    internal class labFour
    {

        public static void Task1()
        {
            Console.WriteLine("Enter a string with number(0-9):");
            string str = Console.ReadLine();
            try
            {
                if (str.Length > int.MaxValue)
                {
                    throw new Exception("Error..");
                }
                int.TryParse(str, out int num);
                Console.WriteLine(num);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                Console.WriteLine("End..."); 
            }
        }
    }
}
