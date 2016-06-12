using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowPlayerHealth : MonoBehaviour {

	public Sprite health_100;
	public Sprite health_80;
	public Sprite health_60;
	public Sprite health_40;
	public Sprite health_20;
	public Sprite health_0;
	public static int hp = 100;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		switch (hp) {
		case 100: this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = health_100;
			break;
		case 80: this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = health_80;
			break;
		case 60: this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = health_60;
			break;
		case 40: this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = health_40;
			break;
		case 20: this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = health_20;
			break;
		case 0: this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = health_0;
			break;
		default:
			break;
		} 
		if(DeathTrigger.alive == false) this.transform.GetComponent<UnityEngine.UI.Image> ().sprite = health_0;
	}
}
