using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour {
	public GameObject enemy;
	public float speedofenemies;
	public float radius;
	public Vector3 instantiaterpos;


	// Use this for initialization
	void Start () {
		instantiaterpos = gameObject.transform.position;

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider col)
	{
		Debug.Log ("in here");
		
		GameObject enemyclone=Instantiate (enemy, new Vector3 (instantiaterpos.x + getrandomnumber (), instantiaterpos.y, instantiaterpos.z + getrandomnumber ()), gameObject.transform.rotation,gameObject.transform) as GameObject;
		
	}
	float getrandomnumber()
	{
		return Random.Range (radius, -radius);
	}
}
