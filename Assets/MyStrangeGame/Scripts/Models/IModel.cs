using UnityEngine;
using System.Collections;

public interface IModel
{
	int score {get;}
	int lives {get;}
	
	void Reset();
	int AddToScore(int value);
	int LoseLife();
}
