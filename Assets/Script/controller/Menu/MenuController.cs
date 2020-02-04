using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

	public GameObject Cursor;
	public int CursorState;
	public float saut;
	public float mini;
	public float maxi;
	public int casenumber;

	public AudioClip cursorsound;
	public AudioClip selectsound;

	public GameObject camera;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		AudioSource sourceaudio = camera.GetComponent<AudioSource> ();
		RectTransform thecursor = Cursor.GetComponent<RectTransform> ();

		if (Input.GetKeyDown ("s")) {
			if (CursorState == casenumber) {
				thecursor.anchoredPosition = new Vector2(thecursor.anchoredPosition.x, mini);
				CursorState = 0;
			} else {
				thecursor.anchoredPosition = new Vector2(thecursor.anchoredPosition.x,thecursor.anchoredPosition.y - saut);
				CursorState++;
			}
			sourceaudio.PlayOneShot (cursorsound);

		}

		if (Input.GetKeyDown ("z")) {
			if (CursorState == 0) {
				thecursor.anchoredPosition = new Vector2(thecursor.anchoredPosition.x, maxi);
				CursorState = casenumber;
			} else {
				thecursor.anchoredPosition = new Vector2(thecursor.anchoredPosition.x,thecursor.anchoredPosition.y + saut);
				CursorState--;
			}
			sourceaudio.PlayOneShot (cursorsound);

		}

		if (Input.GetKeyDown (KeyCode.Return)) {
			sourceaudio.PlayOneShot (selectsound);
			StartCoroutine (SelectSequence ());
			if (CursorState == 0) {
				print ("fdsfds");
				StartCoroutine (Loadlevel("test-map"));
			}
		}
	}


	IEnumerator SelectSequence()
	{
		Image image = Cursor.GetComponent<Image>();
		image.color = new Color(image.color.r,image.color.g,image.color.b,0);
		yield return new WaitForSeconds(0.1f);
		image.color = new Color(image.color.r,image.color.g,image.color.b,255);
		yield return new WaitForSeconds(0.1f);
		image.color = new Color(image.color.r,image.color.g,image.color.b,0);
		yield return new WaitForSeconds(0.1f);
		image.color = new Color(image.color.r,image.color.g,image.color.b,255);
		yield return new WaitForSeconds(0.1f);
		image.color = new Color(image.color.r,image.color.g,image.color.b,0);
		yield return new WaitForSeconds(0.1f);
		image.color = new Color(image.color.r,image.color.g,image.color.b,255);
		yield return new WaitForSeconds(0.1f);
		image.color = new Color(image.color.r,image.color.g,image.color.b,0);
		yield return new WaitForSeconds(0.1f);
		image.color = new Color(image.color.r,image.color.g,image.color.b,255);
		yield return new WaitForSeconds(0.1f);
		image.color = new Color(image.color.r,image.color.g,image.color.b,255);

	}

	IEnumerator Loadlevel(string levelname)
	{
		yield return new WaitForSeconds(1);
		Application.LoadLevel(levelname);
	}
}
