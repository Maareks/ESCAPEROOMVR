using UnityEngine;
using System.Collections;

public class klucz : MonoBehaviour {
	public UnityEngine.UI.Image LeweKolko;
	public UnityEngine.UI.Image PraweKolko;
	static public bool key_box;
	private BoxCollider collider_key;

	void Start () {
		collider_key = GetComponent<BoxCollider> ();
		collider_key.enabled = false;
	}

	void Update () {
		if (komoda.komoda_droga == true) {
			collider_key.enabled= true;
		}
		if ((LeweKolko.fillAmount == 1) && (komoda.komoda_droga == true)){
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
