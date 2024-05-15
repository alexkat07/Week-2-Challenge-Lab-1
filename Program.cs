namespace Week_2_Challenge_Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Temperature() 
            {
                Console.WriteLine("What's the temperature outside?");
                

                int temp = Convert.ToInt32(Console.ReadLine());
                switch (temp) 
                {
                    case <= 10:
                        Console.WriteLine("Freezing weather");
                        break;

                    case <= 20:
                        Console.WriteLine("Very Cold Weather");
                        break;

                    case <= 35:
                        Console.WriteLine("Cold Weather");
                        break;

                    case <= 50:
                        Console.WriteLine("Normal Weather");
                        break;

                    case <= 65:
                        Console.WriteLine("Its Hot");
                        break;

                    case <= 80:
                        Console.WriteLine("Its Very Hot");
                        break;
                        
                        

                }

            
            }

            Temperature();
        }

    }
}
