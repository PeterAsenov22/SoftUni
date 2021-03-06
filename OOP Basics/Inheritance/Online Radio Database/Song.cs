﻿namespace Online_Radio_Database
{
    using System;

    public class Song
    {
        private string artistName;
        private string songName;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        private string ArtistName
        {
            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidArtistNameException);
                }

                this.artistName = value;
            }
        }

        private string SongName
        {
            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidSongNameException);
                }

                this.songName = value;
            }
        }

        public int Minutes
        {
            get { return this.minutes; }
            private set
            {
                if (value < 0 || value > 14)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidSongMinutesException);
                }

                this.minutes = value;
            }
        }

        public int Seconds
        {
            get { return this.seconds; }
            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidSongSecondsException);
                }

                this.seconds = value;
            }
        }
    }
}
