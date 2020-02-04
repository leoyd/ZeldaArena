using UnityEngine;
using System.Collections;

public class Rotationpointercharacter : MonoBehaviour {
	public Vector2 mouse;
	public GameObject player;
	public GameObject cameraObject;
	public Vector2 mousepos;
	public string sens;
	// Use this for initialization
	void Start () {

	}

	void Update () 
	{
		Camera camera = cameraObject.GetComponent<Camera> ();
		Vector3 screenPos = camera.WorldToScreenPoint(player.transform.position);
		Vector2 mousePosition = new Vector2(Input.mousePosition.x , Input.mousePosition.y);
		//print("en X : " + (mousePosition.x - screenPos.x) + " en Y : " + (mousePosition.y - screenPos.y));
		mousepos = new Vector2(mousePosition.x - screenPos.x, mousePosition.y - screenPos.y);
		if (mousepos.x > 30 && mousepos.y < 30 && mousepos.y > -30) {

			sens = ("right");
		}
		if (mousepos.y < -30 && mousepos.x < 30 && mousepos.x > -30) {

			sens = ("down");
		}
		if (mousepos.x < -30 && mousepos.y > -30 && mousepos.y < 30) {

			sens = ("left");
		}
		if (mousepos.y > 30 && mousepos.x > -30 && mousepos.x < 30) {

			sens = ("up");
		}

	}
}
