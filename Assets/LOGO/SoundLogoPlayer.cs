using UnityEngine;
using System.Collections;

public class SoundLogoPlayer : MonoBehaviour {

	public GameObject Logo;
	public AudioClip sound;
	private bool launched=false;

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {

		snaillogoappared audiomod = Logo.GetComponent<snaillogoappared>();
		if(audiomod.bloc==true && launched==false)
		{
			print("lol");
			GetComponent<AudioSource>().PlayOneShot(sound,1);
			launched=true;
			StartCoroutine(wait());
		}
	
	}
	IEnumerator wait()
	{
		snaillogoappared audiomod = Logo.GetComponent<snaillogoappared>();
		   if(audiomod.bloc==true)
		{
			yield return new WaitForSeconds (2);
			Application.LoadLevel("mainMenu");
			}
	}
}
