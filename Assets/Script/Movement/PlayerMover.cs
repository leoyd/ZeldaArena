using UnityEngine;
using System.Collections;

public class PlayerMover : MonoBehaviour {

	public float speed;
	public GameObject playerrender;
	public string sens;
	private Animator animator;
	private Rotationpointercharacter rotationScript;


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		animator = playerrender.GetComponent<Animator> ();
		rotationScript = gameObject.GetComponent<Rotationpointercharacter> ();
		sens = rotationScript.sens;

		if (sens == "up") {
			animator.SetInteger("sens",0);
		}
		if (sens == "right") {
			animator.SetInteger("sens",1);
		}
		if (sens == "down") {
			animator.SetInteger("sens",2);
		}
		if (sens == "left") {
			animator.SetInteger("sens",3);
		}


		if (Input.GetKey("d"))
		{
			animator.SetInteger("movement",1);
			transform.Translate(Vector3.right * Time.deltaTime*speed);
		}

		if (Input.GetKey("q"))
		{
			animator.SetInteger("movement",1);
			transform.Translate(Vector3.left * Time.deltaTime*speed);
		}

		if (Input.GetKey("s"))
		{
			animator.SetInteger("movement",1);
			transform.Translate(Vector3.down * Time.deltaTime*speed);
		}

		if (Input.GetKey("z"))
		{
			animator.SetInteger("movement",1);
			transform.Translate(Vector3.up * Time.deltaTime*speed);
		}

		if (!Input.GetKey ("z") && !Input.GetKey ("d") && !Input.GetKey ("s") && !Input.GetKey ("q"))
			animator.SetInteger ("movement",0);
	
	}
}
