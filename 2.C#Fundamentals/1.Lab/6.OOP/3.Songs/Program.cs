using System;
using System.Collections.Generic;

namespace _3.Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                
                Song song = new Song();

                song.TypeList = input[0];
                song.Name = input[1];
                song.Time = input[2];

                songs.Add(song);
            }

            string lastLine = Console.ReadLine();

            if (lastLine == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }       
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == lastLine)
                    {
                    Console.WriteLine(song.Name);
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
}
