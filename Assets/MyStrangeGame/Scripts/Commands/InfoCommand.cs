using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace strangeMy{

	public class InfoCommand : IMyCommand {
		
		public void execute()
		{
			Debug.Log ("InfoCommand execute!!!");
		}
	}
}


