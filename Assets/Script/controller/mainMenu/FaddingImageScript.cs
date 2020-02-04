using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FaddingImageScript : MonoBehaviour {

	public float faddingWaittime;
	private int n;
	private bool security=false;
	
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
			Image image = GetComponent<Image>();
			//rendu.material.color.a=n;
			//Color color = rendu.material.color;
			//color.a += 1;
			image.color += new Color(0,0,0,0.005f);
			n=n+1;
			print (n);
			
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
			Image image = GetComponent<Image>();
			//rendu.material.color.a=n;
			//Color color = rendu.material.color;
			//color.a -= 1;
			n=n+1;
			print (n);
			image.color -= new Color(0,0,0,0.005f);
		}
		security=false;
		
		
	}
	
	public void reset()
	{
		
		
		Image image = GetComponent<Image>();
		//rendu.material.color.a=n;
		//Color color = rendu.material.color;
		//color.a -= 1;
		image.color = new Color(0,0,0,255);
	}
}
