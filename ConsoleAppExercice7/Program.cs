namespace ConsoleAppExercice7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un nombre entier (base 10) : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n} en binaire : {ConvertirEnBinaire(n)}");
        }

        static string ConvertirEnBinaire(int n)
        {
            if (n == 0) return "0";

            string binaire = "";

            while (n > 0)
            {
                binaire = (n % 2) + binaire; 
                n = n / 2;                   
            }

            return binaire;
        }
    }
}
