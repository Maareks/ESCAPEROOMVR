using UnityEngine;
using System.Collections;

public class komoda : MonoBehaviour {
	public UnityEngine.UI.Image LeweKolko;
	public UnityEngine.UI.Image PraweKolko;
	private BoxCollider collider_komoda;
	static public bool komoda_droga; 

	void Start () {
		collider_komoda = GetComponent<BoxCollider> ();
		komoda_droga = false;
	}

	void Update () {
		if (LeweKolko.fillAmount == 1) {
			LeweKolko.fillAmount = 0;
			komoda_droga = true;
			collider_komoda.enabled=false;
		}
	}

	void Ciagle(){
		LeweKolko.fillAmount += Time.deltaTime;
	}

	void Koniec(){
		LeweKolko.fillAmount = 0;
	}
}
