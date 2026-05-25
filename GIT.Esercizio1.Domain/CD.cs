using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT.Esercizio1.Domain
{
    public class CD
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; }
        public List<Song> Songs { get; set; }
        public CD(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string getAuthor()
        {
            return Author;
        }
        public string getTitle()
        {
            return Title;
        }
        public void setAuthor(string author)
        {
            Author = author;
        }
        public void setTitle(string title)
        {
            Title = title;
        }
        public string toString()
        {
            foreach(Song song in Songs)
            {
                return $"Titolo: {Title}, Author: {Author}, Duration: {Duration}, Songs: {song.toString()}";
            }
            return $"Titolo: {Title}, Author: {Author}, Duration: {Duration}";
        }
        public int duration()
        {
            foreach(Song song in Songs)
            {
                Duration += song.GetDuration();
            }
            return Duration;
        }
    }
}
