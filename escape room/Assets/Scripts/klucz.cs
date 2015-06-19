using UnityEngine;
using System.Collections;

public class klucz : MonoBehaviour {
	public UnityEngine.UI.Image LeweKolko;
	public UnityEngine.UI.Image PraweKolko;
	static public bool key_box;

	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
		if (LeweKolko.fillAmount == 1) {
			LeweKolko.fillAmount = 0;
			gameObject.SetActive (false);
			key_box = true;
		}
	}
	void Ciagle(){
		LeweKolko.fillAmount += Time.deltaTime;
	}
	void Koniec(){
		LeweKolko.fillAmount = 0;
	}
}
