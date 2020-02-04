using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class text_clignote : MonoBehaviour {

	public float wait_time;

	// Use this for initialization
	void Start () {
		StartCoroutine(wait ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator wait()
	{
		Text txt = gameObject.GetComponent<Text>();
		yield return new WaitForSeconds(wait_time);
		txt.color = new Color(txt.color.r,txt.color.g,txt.color.b,0);
		yield return new WaitForSeconds(wait_time);
		txt.color = new Color(txt.color.r,txt.color.g,txt.color.b,255);
		StartCoroutine(wait ());

	}
}
