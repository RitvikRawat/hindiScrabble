using UnityEngine;
using System.Collections;

public class intersection : MonoBehaviour {
	public GameObject x;
	public GameObject y;
	public bool ismixed=false;
	public Collider2D col;
	//public drag z;;

	public GameObject[] arr;
	void Start()
	{
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "vowel" && gameObject.GetComponent<place> ().placed == false) {
			Debug.Log("entered");
			string s = other.gameObject.GetComponentInChildren<Point> ().Unicode;
			int a = int.Parse (s.Substring (s.Length - 2));
			Debug.Log(a);
			if (a>=6 && a<=24 && arr[a-6]!=null) {
				Debug.Log("Hi");
				x = arr [a-6];
			}
			other.gameObject.GetComponent<place>().ontop=true;
			y.GetComponent<place>().ontop=true;
			col=other;
		}

	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "vowel" && gameObject.GetComponent<place>().placed==false) {
			Debug.Log("Exited");
			x=null;
			other.gameObject.GetComponent<place>().ontop=false;
			y.GetComponent<place>().ontop=false;
		}
	}
	void Update()
	{
		//Debug.Log (b);
		if (Chance.added2 == false && y.GetComponent<place>().ontop== true) {
			Debug.Log ("mixed");
			Vector3 pos = y.transform.position;
			x=(GameObject.Instantiate (x, pos, Quaternion.identity) as GameObject);
			Chance.list.Add(x);
			Debug.Log ("added");
			Vector2 ind=Chance.getIndex(y);
			Board.unicode[(int)ind.x,(int)ind.y]=x.GetComponentInChildren<Point>().Unicode;
			//Debug.Log(Board.unicode[(int)ind.x,(int)ind.y]);
			col.gameObject.SetActive (false);
			y.SetActive (false);
			Chance.added2 = true;
			y.GetComponent<place>().ontop=false;
		}
	}
}