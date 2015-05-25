using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.mediation.impl;

namespace strangeMy{

public class GameContextView : ContextView {

	public View obj;
	void Awake()
	{
		View o = Instantiate(obj);
	    context = new GameContext( this, o );
		//context.Start();
	}
}
}
