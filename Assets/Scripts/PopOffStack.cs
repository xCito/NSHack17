using UnityEngine;
using System.Collections;

public class PopOffStack : MonoBehaviour {

	Transform offStack;
	Transform onStack;
	GameObject[] items;
	int curIndex;
	// Use this for initialization
	void Start () {
		offStack = GameObject.Find ("OffStack").transform;
		onStack = GameObject.Find ("OnStack").transform;
		items = GameObject.FindGameObjectsWithTag ("StackItem");
		curIndex = 0;//items.Length - 1;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			popOffStack ();
		}

		if (Input.GetKeyDown ("b")) {
			pushToStack ();
		}
	}

	void popOffStack()
	{
		items [curIndex].transform.position = new Vector3 (offStack.position.x,
			15,
			offStack.position.z);
		if(curIndex < items.Length-1)
			curIndex++;
	} 

	void pushToStack()
	{
		items [curIndex].transform.position = new Vector3 (onStack.position.x,
			15,
			onStack.position.z);

		if(curIndex == 0)
			return;
		curIndex--;
	} 
}
