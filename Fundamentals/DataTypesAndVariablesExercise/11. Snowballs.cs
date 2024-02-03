namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            int snowballValue = 0;
            int min = int.MinValue;
            int highestSnow = 0;
            int highestTime = 0;
            int highestQuality = 0;
            int highestValue = 0;

            for (int i = 1; i <= snowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = (int)Math.Pow((snowballSnow / snowballTime), snowballQuality);
                if(snowballValue >= min)
                {
                    min = snowballValue;
                    highestSnow += snowballSnow;
                    highestTime += snowballTime;
                    highestQuality += snowballQuality;
                    highestValue += snowballValue;
                }
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {highestValue} ({highestQuality})");
        }
    }
}
