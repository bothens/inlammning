using System;

//Huvudklass
public class Fotboll
{// attribut av Huvudklass
	public string Boll;
	public int players;

	//metod
	public void Kick()
	{
		Console.WriteLine("players kick the ball");
	}
      public void run()
    {
        Console.WriteLine("players run after the ball");
    }
}
// subklass
public class Defender : Fotboll
	{ 
		public int height;
		//metod
		public void tackle()
		{
			Console.WriteLine("the defender tackles");	
		}
    }


