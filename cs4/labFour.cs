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
        public static void Task2()
        {
            Console.WriteLine("Enter a string with number(0-1):");
            string str = Console.ReadLine();
            int res = 0;
            try
            {
                if (str.Length > int.MaxValue)
                {
                    throw new Exception("Error..");
                }
                int exponent = 1;
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    if (str[i] == '1')
                    {
                        res += exponent;
                    }
                    exponent*=2;
                }
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("End...");
            }
        }
        public static void Task3() 
        {
            Console.Write("Enter number of card:  ");
            string Num = Console.ReadLine();
            Console.Write("Enter PIP:  ");
            string PIP = Console.ReadLine();
            Console.Write("Enter CVC:  ");
            int.TryParse(Console.ReadLine(), out int CVC);
            Console.Write("Enter date work completion (DD.MM.YYYY):  ");
            string input = Console.ReadLine();
            DateOnly.TryParse(input, out DateOnly Complite);
            Console.Write("Enter Pine-Code:  ");
            int.TryParse(Console.ReadLine(), out int PineCode);

            CreditCard card = new CreditCard(Num, PIP, CVC, Complite, PineCode);
            card.ShowInfo();
        }
        public static void Task4()
        {
            try
            {
                Console.WriteLine("Enter a mathematical expression containing only integers and * operator:");
                string expression = Console.ReadLine();

                int result = Calculate(expression);

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("End...");
            }
        }
        //4
        static int Calculate(string expression)
        {
            string[] parts = expression.Split('*');
            int result = 1;

            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int value))
                {
                    throw new ArgumentException("Invalid expression format.");
                }
                result *= value;
            }

            return result;
        }
    }

    //3
    class CreditCard
    {   
        public string NumberOfCard { get; set; }
        public string PIP { get; set; }
        public int CVC { get; set; }
        public DateOnly Complite { get; set; }
        public int PineCode { get; set; }
        public CreditCard(string num, string pip, int cvc, DateOnly complite, int pine)
        {
            try
            {
                if (num == null)
                {
                    throw new Exception("Error...");
                }
                if (pip == null)
                {
                    throw new Exception("Error...");
                }
                if (cvc < 100 || cvc > 999)
                {
                    throw new Exception("Error...");
                }
                if (complite.Equals(3.3))
                {
                    throw new Exception("Error...");
                }
                if (cvc < 1000 || cvc > 9999)
                {
                    throw new Exception("Error...");
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                NumberOfCard = num;
                PIP = pip;
                CVC = cvc;
                Complite = complite;
                PineCode = pine;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Number of card:\t\t{NumberOfCard}");
            Console.WriteLine($"PIP:\t\t\t{PIP}");
            Console.WriteLine($"CVC:\t\t\t{CVC}");
            Console.WriteLine($"Date work completion:   {Complite}");
            Console.WriteLine($"Pine-Code:\t\t{PineCode}");
        }
    }
}
