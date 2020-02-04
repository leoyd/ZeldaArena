using UnityEngine;
using System.Collections;

public class fadingSpritesScript : MonoBehaviour {

	public float faddingWaittime;
	private int n;
	public bool security=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void close()
	{
		if(security==false)
		StartCoroutine(closeFading());
	}

	public void open()
	{
		if(security==false)
		StartCoroutine(openFading());
	}


	public IEnumerator openFading()
	{
		n=0;
		while(n!=255)
		{
			security=true;
			yield return new WaitForSeconds(faddingWaittime);
			SpriteRenderer rendu = GetComponent<SpriteRenderer>();
			//rendu.material.color.a=n;
			//Color color = rendu.material.color;
			//color.a += 1;
			rendu.material.color += new Color(0,0,0,0.005f);
			n=n+1;
		
		}
		security=false;
	
	}

	public IEnumerator closeFading()
	{
		n=0;
		while(n!=255)
		{
			security=true;
			yield return new WaitForSeconds(faddingWaittime);
			SpriteRenderer rendu  = GetComponent<SpriteRenderer>();
			//rendu.material.color.a=n;
			//Color color = rendu.material.color;
			//color.a -= 1;
			rendu.material.color -= new Color(0,0,0,0.005f);
			n=n+1;
			
		}
		security=false;


	}


}
