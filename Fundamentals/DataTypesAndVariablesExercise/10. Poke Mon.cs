namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustion = int.Parse(Console.ReadLine());
            int target = 0;
            int half = pokePower / 2;
            while (pokePower > distance) 
            {
                pokePower -= distance;
                target++;

                if (pokePower == half && exhaustion != 0) 
                {
                    pokePower = pokePower / exhaustion;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(target);
        }
    }
}
