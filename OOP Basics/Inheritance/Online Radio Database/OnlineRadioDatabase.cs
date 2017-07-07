namespace Online_Radio_Database
{
    using System;
    using System.Linq;

    public class OnlineRadioDatabase
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var totalSongs = 0;
            var songsLength = new TimeSpan(0, 0, 0);
            for (int i = 0; i < n; i++)
            {
                try
                {
                    var songParams = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    if (songParams.Length != 3)
                    {
                        throw new ArgumentException(ExceptionMessages.InvalidSongException);
                    }

                    var lengthParams = songParams[2].Split(':').ToArray();
                    if (lengthParams.Length != 2)
                    {
                        throw new ArgumentException(ExceptionMessages.InvalidSongLengthException);
                    }

                    int min;
                    int sec;

                    var isMinParsed = int.TryParse(lengthParams[0], out min);
                    var isSecParsed = int.TryParse(lengthParams[1], out sec);

                    if (isSecParsed && isMinParsed)
                    {
                        var song = new Song(songParams[0], songParams[1], min, sec);
                        Console.WriteLine("Song added.");
                        totalSongs++;
                        var songLength = new TimeSpan(0, song.Minutes, song.Seconds);
                        songsLength = songsLength.Add(songLength);
                    }
                    else
                    {
                        throw new ArgumentException(ExceptionMessages.InvalidSongLengthException);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Songs added: {totalSongs}");
            Console.WriteLine($"Playlist length: {songsLength.Hours}h {songsLength.Minutes}m {songsLength.Seconds}s");
        }
    }
}
