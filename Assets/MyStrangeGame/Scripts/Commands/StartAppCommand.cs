using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace strangeMy{

    public class StartAppCommand : Command {

        [Inject]
	    public IGameService service{ get; set;} 

		
		[Inject (ContextKeys.CONTEXT_DISPATCHER)]
		public IEventDispatcher eventBus {get; set; }

	    public override void Execute()
	    {
		    Debug.Log ("Start App");
			eventBus.AddListener(ServiceEvent.StartServerResponce, serverResponce);
			eventBus.AddListener(MyCommands.Info, InfoResponse);

			Retain ();

			service.StartServer(6800);

			// create game field

		}
		
		void serverResponce()
		{
			Debug.Log("Server responced!!!");
			eventBus.RemoveListener(ServiceEvent.StartServerResponce, serverResponce);
			Release();
		}

		void InfoResponse()
		{
			Debug.Log ("InfoCommand execute!!!");
		}
    }

}
