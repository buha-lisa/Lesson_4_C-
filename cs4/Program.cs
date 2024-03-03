namespace cs4
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter the task(1-4):  ");
            int.TryParse(Console.ReadLine(), out int task);
            switch (task)
            {
                case 1:
                    labFour.Task1();
                    break;
                case 2:
                    labFour.Task2();
                    break;
                case 3:
                    labFour.Task3();
                    break;
                case 4:
                    labFour.Task4();
                    break;
            }
        }
    }
}
