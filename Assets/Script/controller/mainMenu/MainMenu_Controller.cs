using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenu_Controller : MonoBehaviour {

	public GameObject mask;
	public GameObject pressstarttext;
	public float speed;
	public float faddingWaittime;
	public float waitbeforesceneload;
	public string levelname;
	public GameObject camera;
	public AudioClip startsound;

	// Use this for initialization
	void Start () {

		StartCoroutine(introSequence ());
	
	}
	
	// Update is called once per frame
	void Update () {
		fadingSpritesScript scriptimage = mask.GetComponent<fadingSpritesScript> ();
		if (Input.GetKeyDown (KeyCode.Return) && scriptimage.security == false) {
			SpriteRenderer image = mask.GetComponent<SpriteRenderer>();
			image.color = new Color(0,0,0,image.color.a);
			scriptimage.open();
			pressstarttext.SetActive (false);
			StartCoroutine (wait ());
		}
	}

	IEnumerator introSequence()
	{
		SpriteRenderer image = mask.GetComponent<SpriteRenderer>();
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(0,0,0,255);
		yield return new WaitForSeconds(speed);
		image.color = new Color(255,255,255,255);

		fadingSpritesScript scriptimage = mask.GetComponent<fadingSpritesScript> ();
		scriptimage.close ();
		pressstarttext.SetActive(true);


	}

	IEnumerator wait()
	{
		camera.GetComponent<AudioSource> ().Stop ();
		camera.GetComponent<AudioSource>().PlayOneShot(startsound);
		pressstarttext.GetComponent<text_clignote>().wait_time = 0.1f;
		yield return new WaitForSeconds (waitbeforesceneload);
		Application.LoadLevel(levelname);
	}

}
