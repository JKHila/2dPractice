using UnityEngine;
using System.Collections;

public class csEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//e = GameObject.Find ("Enemy");
	}


	// Update is called once per frame
	void Update () {
	
		if (transform.position.x < -10)
			Destroy (this.gameObject);


	}
}
