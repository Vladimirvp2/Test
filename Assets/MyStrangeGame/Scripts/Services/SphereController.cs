using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.impl;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;
using strange.extensions.mediation.impl;

namespace strangeMy{

	public class SphereController : View {//MonoBehaviour  {

	[Inject (ContextKeys.CONTEXT_DISPATCHER)]
	public IEventDispatcher eventBus {get; set; }

	[Inject]
	public IMyCommand comm { get; set; }

	public Vector2 curSavePoint;
	public float playerSpeed = 5.0f;
	private bool isMove = false;
	private float spawnSpeed;




	//[Inject(ContextKeys.CROSS_CONTEXT_DISPATCHER)]
	//public IEventDispatcher eventBus{get;set;}
	
	void Start(){
		spawnSpeed = playerSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		float transV = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
		float transH = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
		
		transform.Translate( new Vector3(transH, transV, 0));
		
		if (transV != 0 || transH != 0) {
			isMove = true;
		} else {
			isMove = false;
		}
		
		if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) {
			playerSpeed = 10.0f;
		} else {
			playerSpeed = spawnSpeed;
		}

		if (transform.position.x >= 5)
		{
			if (eventBus != null)
			{
//			    eventBus.Dispatch(MyCommands.Info);
	
			}
			else
			{
				Debug.Log ("NULL BUSS");
			}

				if (comm != null)
				{
					comm.execute();
				}
				else
				{
					Debug.Log("NULL!");
				}
		}
	}
	
	public bool isMoved()
	{
		return isMove;
	}
	
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "savePoint") {
			curSavePoint = transform.position;
			print("SavePoint");
		}
		if (col.tag == "killPoint") {
			transform.position = curSavePoint;
		}
	}
}

}