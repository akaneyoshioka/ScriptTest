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
		int b = mp - a;
		if (b > 53) {
			Debug.Log ("MPが足りないため魔法が使えない。");
		} else {
			Debug.Log ("魔法攻撃をした。残りMPは" + b);
		}
	}
			
}

public class Test : MonoBehaviour {

	void Start(){
		Boss lastboss = new Boss ();
		lastboss.Attack ();
		lastboss.Defence (3);

		Boss hit = new Boss ();
		hit.Magic (5);

		int[] array = { 1, 2, 3, 4, 5 };
		for (int i = 0; i < array.Length; i++) {
			Debug.Log (array [i]);
		}
	}
	void Update(){
	}

}
