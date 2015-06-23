using UnityEngine;
using System.Collections;

public class komoda : MonoBehaviour {
	public UnityEngine.UI.Image LeweKolko;
	public UnityEngine.UI.Image PraweKolko;
	private BoxCollider collider_komoda;
	static public bool komoda_droga; 
	public bool testklucz;

	void Start () {
		collider_komoda = GetComponent<BoxCollider> ();
		komoda_droga = false;
	}

	void Update () {
		testklucz = komoda_droga;
		if (LeweKolko.fillAmount == 1) {
			LeweKolko.fillAmount = 0;
			collider_komoda.enabled=false;
			komoda_droga = true;
		}
	}

	void Ciagle(){
		LeweKolko.fillAmount += Time.deltaTime;
	}

	void Koniec(){
		LeweKolko.fillAmount = 0;
	}
}
