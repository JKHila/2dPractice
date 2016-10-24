using UnityEngine;
using System.Collections;

public class csBack : MonoBehaviour {
	public float Boffset = 0;
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Boffset += Time.deltaTime * speed;
		GetComponent<Renderer>().material.mainTextureOffset = new Vector2 (Boffset, 0);
	
	
	}
}
