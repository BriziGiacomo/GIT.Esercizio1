namespace GIT.Esercizio1.Domain
{
    public class Song
    {
        //Attributes
        private string Title;
        private string Author;
        private int Duration;

        //Constructor
        public Song(string title, string author, int duration) 
        {
            Title = title;
            Author = author;
            Duration = duration;
        }

        //Setters
        public void SetTitle(string title) 
        {
            Title = title;
        }
        public void SetAuthor(string author) 
        {
            Author = author;
        }
        public void SetDuration(int duration)
        {
            Duration = duration;
        }

        //Getters
        public string GetTitle() 
        {
            return Title;
        }
        public string GetAuthor()
        {
            return Author;
        }
        public int GetDuration()
        {
            return Duration;
        }

        public string toString() 
        {
            return $"Titolo: {Title}, Author: {Author}, Duration: {Duration}";
        }

        public bool shortSong(int shortDuration) 
        { 
            if(Duration<shortDuration)
                return true;
            else 
                return false;
        }
    }
}
