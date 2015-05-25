using UnityEngine;
using System.Collections;


	public class Model1 : IModel
	{
		private int initLives = 3;
		private int _score;
		private int _lives;
		
		public Model1()
		{
			Reset ();
		}
		
		public int AddToScore(int value)
		{
			_score += value;
			return score;
		}
		
		public int LoseLife()
		{
			_lives = Mathf.Max(0, _lives - 1);
			return lives;
		}
		
		public void Reset()
		{
			_score = 0;
			_lives = initLives;
		}
		
		public int score
		{
			get
			{
				return _score;
			}
		}
		
		public int lives
		{
			get
			{
				return _lives;
			}
		}
}
