namespace ConsoleApp1
{
   public class Player
    {
        
        // Detta är den privata attributen
       private string game;
       
        //Konstruktör
        public Player(string game)
        {
            Game = game;
        }


        // Public metod
        public string Game
        {
            get { return game; }
            set { game = value; }
        }
    }
}

