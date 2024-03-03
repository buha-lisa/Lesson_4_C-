namespace cs4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the task(1-6):  ");
            int.TryParse(Console.ReadLine(), out int task);
            switch (task)
            {
                case 1:
                    labFour.Task1();
                    break;
            }
        }
    }
}
