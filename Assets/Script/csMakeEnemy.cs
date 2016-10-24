using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class csMakeEnemy : MonoBehaviour {
	public float RTime;
	public float reload = 3;
	public float posY =0;
	public GameObject Enemy;
	public GameObject sPannel;
	public GameObject gPannel;
	public Text scoreBoard;
	public Text damageBoard;
	public int score = 0;
	public int hp = 100;
	// Use this for initialization
	void startGame()
	{
		sPannel.SetActive(false);
		gPannel.SetActive(true);
	}
	void addScore(int point)
	{
		score += point;

	}

	void addDamage(int point)
	{
		hp -= point;
	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RTime += Time.deltaTime;
		while (RTime>reload) {
			posY = Random.Range (2, 10);
			Instantiate(Enemy,new Vector3(11,posY,-1), transform.rotation);
			RTime =0;
		}
	}
}
