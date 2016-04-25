using UnityEngine;
using System.Collections;

public class Penalty : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static double penalty (int l ,int r, int u, int d)
	{
		double pen = 0;
		double[] distance = { 0, 1, 0.75, 0.5, 0.25, 0.10, 0.05, 0.025, 0.025};
		int dis = 0;
//up to down word
		if (l == r) {
			//checking the top
			for (dis=1; (dis<=8)&&(u-dis>=0)&&(u-dis<=15); dis++) {
				if (Board.powers [u - dis, l] == 3) {
					pen += 10 * distance [dis];
				}
				if (Board.powers [u - dis, l] == 2) {
					pen += 6 * distance [dis];
				}
				if (Board.multiples [u - dis, l] == 3) {
					pen += 4 * distance [dis];
				}
				if (Board.multiples [u - dis, l] == 2) {
					pen += 2 * distance [dis];
				}
			}
			//checking the bottom
			for (dis=1; (dis<=8)&&(d+dis>=0)&&(d+dis<=15); dis++) {
				if (Board.powers [d + dis, l] == 3) {
					pen += 10 * distance [dis];
				}
				if (Board.powers [d + dis, l] == 2) {
					pen += 6 * distance [dis];
				}
				if (Board.multiples [d + dis, l] == 3) {
					pen += 4 * distance [dis];
				}
				if (Board.multiples [d + dis, l] == 2) {
					pen += 2 * distance [dis];
				}

			}
			//checking the right side
			for (int i=u; i<=d; i++) {
				for (dis=1; (dis<=8)&&(l+dis>=0)&&(l+dis<=15); dis++) {
					if (Board.powers [i, l + dis] == 3) {
						pen += 10 * distance [dis];
					}
					if (Board.powers [i, l + dis] == 2) {
						pen += 6 * distance [dis];
					}
					if (Board.multiples [i, l + dis] == 3) {
						pen += 4 * distance [dis];
					}
					if (Board.multiples [i, l + dis] == 2) {
						pen += 2 * distance [dis];
					}
				}
			}

			//checking the left side
			for (int i=u; i<=d; i++) {
				for (dis=1; (dis<=8)&&(l-dis>=0)&&(l-dis<=15); dis++) {
					if (Board.powers [i, l - dis] == 3) {
						pen += 10 * distance [dis];
					}
					if (Board.powers [i, l - dis] == 2) {
						pen += 6 * distance [dis];
					}
					if (Board.multiples [i, l - dis] == 3) {
						pen += 4 * distance [dis];
					}
					if (Board.multiples [i, l - dis] == 2) {
						pen += 2 * distance [dis];
					}
				}
			}
		
		} 
//left to right word
		else 
		{
			//checking the left side
			for(dis=1;(dis<=8)&&(l-dis>=0)&&(l-dis<=15);dis++)
			{
				if (Board.powers [u ,l-dis] == 3) {
					pen += 10 * distance [dis];
				}
				if (Board.powers [u ,l-dis] == 2) {
					pen += 6 * distance [dis];
				}
				if (Board.multiples [u ,l-dis] == 3) {
					pen += 4 * distance [dis];
				}
				if (Board.multiples [u ,l-dis] == 2) {
					pen += 2 * distance [dis];
				}
			}
			//checking the right side
			for(dis=1;(dis<=8)&&(r+dis>=0)&&(r+dis<=15);dis++)
			{
				if (Board.powers [u ,r+dis] == 3) {
					pen += 10 * distance [dis];
				}
				if (Board.powers [u ,r+dis] == 2) {
					pen += 6 * distance [dis];
				}
				if (Board.multiples [u ,r+dis] == 3) {
					pen += 4 * distance [dis];
				}
				if (Board.multiples [u ,r+dis] == 2) {
					pen += 2 * distance [dis];
				}
			}
			//checking the top
			for(int i=l;i<=r;i++)
			{
				for(dis=1;(dis<=8)&&(u-dis>=0)&&(u-dis<=15);dis++)
				{
					if (Board.powers [u-dis, i] == 3) {
						pen += 10 * distance [dis];
					}
					if (Board.powers [u-dis, i] == 2) {
						pen += 6 * distance [dis];
					}
					if (Board.multiples [u-dis, i] == 3) {
						pen += 4 * distance [dis];
					}
					if (Board.multiples [u-dis, i] == 2) {
						pen += 2 * distance [dis];
					}
				}
			}
			//checking the bottom
			for(int i=l;i<=r;i++)
			{
				for(dis=1;(dis<=8)&&(u+dis>=0)&&(u+dis<=15);dis++)
				{
					if (Board.powers [u+dis, i] == 3) {
						pen += 10 * distance [dis];
					}
					if (Board.powers [u+dis, i] == 2) {
						pen += 6 * distance [dis];
					}
					if (Board.multiples [u+dis, i] == 3) {
						pen += 4 * distance [dis];
					}
					if (Board.multiples [u+dis, i] == 2) {
						pen += 2 * distance [dis];
					}
				}
			}
		}
	
		return pen;
	}
}