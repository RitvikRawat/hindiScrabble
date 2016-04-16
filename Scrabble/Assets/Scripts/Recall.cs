﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Recall: MonoBehaviour {
	public static GameObject obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static void recall()
	{
		Debug.Log ("recall");
		for (int i=0; i<Chance.list.Count; i++) 
		{
			obj=Chance.list[i];
			obj.SetActive(true);
			Vector2 ind=Chance.getIndex(obj);
			Board.matrix[(int)ind.x,(int)ind.y]=0;
			if(obj.tag=="mixed")
				Destroy(obj);
			else
			{
				obj.transform.position=obj.GetComponent<place>().initialpos;
				obj.GetComponent<place>().onboard=false;
				obj.GetComponent<place>().ontop=false;
			}
		}
		Chance.list.Clear ();
	}
}
