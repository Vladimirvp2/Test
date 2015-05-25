using UnityEngine;
using System.Collections;


namespace strangeMy{

    public interface IGameService  {

		void Connect(string host, int port);
		void StartServer(int port);
    }

	public enum ServiceEvent
	{
		ConnectResponce,
		StartServerResponce
	}

}
