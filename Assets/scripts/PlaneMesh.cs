using UnityEngine;
using System.Collections;

public class PlaneMesh : MonoBehaviour {
	public int shaken = 0;

	public int stirred = 0;
	//public string = "sami o paras"; //Samin kommentti....
	// Use this for initialization
	void Start () {
		//Can you see this?

		//enkä tee mittäää


		//Can you saaaaaat
		Debug.Log (jamespond (shaken, stirred));
	}
	
	// Update is called once per frame
	void Update () {
	//can you nabnab
	}

	int jamespond(int i, int j){
		int sum = 0;
		sum = i + j;
		return sum;
	}
}
