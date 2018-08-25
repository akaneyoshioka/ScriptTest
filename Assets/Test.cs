using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int hp=100;
	private int power=25;
	private int mp=53;

	public void Attack(){
		Debug.Log (this.power + "のダメージを与えた");
	}
	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");
	}
	public void Magic(int a){
		if (mp>=a) {
			mp -= a;
			Debug.Log("魔法攻撃をした。残りMPは"+mp);
		} else {
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
			
}

public class Test : MonoBehaviour {

	void Start(){
		Boss lastboss = new Boss ();
		lastboss.Attack ();
		lastboss.Defence (3);

		Boss hit = new Boss ();
		hit.Magic (55);

		int[] array = { 0, 1, 2, 3, 4 };

		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}

			for(int j=4;j>=0;j--){
			Debug.Log (array [j]);
			}
	}
	void Update(){
	}

}
