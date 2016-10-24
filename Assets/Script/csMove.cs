using UnityEngine;
using System.Collections;

public class csMove : MonoBehaviour {
	public float speed =10;
	public Animator anim;
//	public GameObject player;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	
	}
	void OnTriggerEnter2D(Collider2D coll)
	{
		anim.SetBool ("Hitted", true);
	}
	// Update is called once per frame
	void Update () {
		float mv = Input.GetAxis ("Vertical");
		float mh = Input.GetAxis ("Horizontal");

		transform.Translate (Vector2.up * Time.deltaTime * speed*mv);
		transform.Translate (Vector2.right * Time.deltaTime * speed*mh);


		float posX = transform.position.x;
		float posY = transform.position.y;

		posX = Mathf.Clamp (posX, -7, 8);
		posY = Mathf.Clamp (posY, -2, 6.7f);

		transform.position = new Vector3 (posX, posY, -1);

		anim.SetFloat ("hMove", mh);



	}
}
