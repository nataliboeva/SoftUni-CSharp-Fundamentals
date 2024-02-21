namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 1; i <= n; i++)
            {
                string[] data = Console.ReadLine().Split("_");
                string typeList = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();
                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songs)
                {
                    if (song.TypeList == command)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    public class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
}