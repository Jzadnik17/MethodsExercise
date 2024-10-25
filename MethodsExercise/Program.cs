namespace MethodsExercise
{
    public class Program
    {
        public static void Madlib()

        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite city?");
            string favCity = Console.ReadLine();


            Console.WriteLine($"One day, {userName} was walking through the woods while wearing a {favColor} shirt. {userName} saw a {favAnimal} listening to {favBand}, and wanted to ride on the {favAnimal} to go and see {favBand} in {favCity}.");
        }

        public static int Add(int numOne, int numTwo)
        { 
            
            return numOne + numTwo; 
      
        }

        public static int Subtract (int numOne, int numTwo)

        {   return numOne - numTwo;
        
        
        }
        public static int Multiply (int numOne, int numTwo)

        { return numOne * numTwo;
        
        
        }

        public static int Divide(int numOne, int numTwo)
        { 
        
         return (numOne / numTwo);
        
        }
        static void Main(string[] args)
        {
            Madlib();

            Console.WriteLine(Add(numOne: 3, numTwo: 4));
            
            Console.WriteLine(Subtract (numOne:212, numTwo : 5));

            Console.WriteLine(Multiply(numOne:2, numTwo: 4));

            Console.WriteLine(Divide (numTwo:2, numOne: 3));
        }
    }
}
