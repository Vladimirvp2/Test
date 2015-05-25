using UnityEngine;
using System.Collections;

namespace strangeMy{

    public interface IMyCommand {

	    void execute();
    }

	public enum MyCommands
	{
		Info
	}

}
