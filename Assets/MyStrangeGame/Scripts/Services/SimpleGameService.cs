using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace strangeMy{

    public class SimpleGameService : IGameService {

		[Inject (ContextKeys.CONTEXT_DISPATCHER)]
		public IEventDispatcher eventBus {get; set; }

		public void Connect(string host, int port)
		{

		}

		public void StartServer(int port)
		{
			Debug.Log("Starting Server");

			eventBus.Dispatch(ServiceEvent.StartServerResponce);
		}
    }
}
