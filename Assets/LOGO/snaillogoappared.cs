using UnityEngine;
using System.Collections;

public class snaillogoappared : MonoBehaviour {

	public float temps;
	private float index;
	public float speed;
	public bool bloc=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		index=0;


			if(bloc==false)
			transform.Translate(new Vector3(0,Time.deltaTime*-speed,0));
			
			

		
		transform.Translate(new Vector3(0,0,0));
	
	}

	void OnTriggerEnter2D(Collider2D other)
		
	
	{
		print("cabloc");
		bloc=true;
		transform.Translate(new Vector3(0,0,0));
	}
}
