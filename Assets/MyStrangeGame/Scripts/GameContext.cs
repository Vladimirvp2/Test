using UnityEngine;
using System.Collections;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;
using strange.extensions.context.impl;
using strange.extensions.context.api;
using strange.extensions.mediation.impl;

namespace strangeMy{

public class GameContext : MVCSContext {

		private View ob;
    public GameContext (MonoBehaviour view, View obj) : base(view)
	{
		ob = obj;
		injectionBinder.injector.Inject(ob);
	}

	protected override void mapBindings()
	{
		injectionBinder.Bind<IGameService>().To<SimpleGameService>().ToSingleton();
		injectionBinder.Bind<IMyCommand>().To<InfoCommand>().ToSingleton();
		

		commandBinder.Bind(ContextEvent.START).To<StartAppCommand>();
		
	}
}

}
