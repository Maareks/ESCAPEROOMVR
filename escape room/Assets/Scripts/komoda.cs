using UnityEngine;
using System.Collections;

public class komoda : MonoBehaviour {
	public UnityEngine.UI.Image LeweKolko;
	public UnityEngine.UI.Image PraweKolko;
	private BoxCollider box;
	static public bool komoda_droga; 

	void Start () {
		box = GetComponent<BoxCollider> ();
		komoda_droga = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (LeweKolko.fillAmount == 1) {
			LeweKolko.fillAmount = 0;
			box.enabled=false;
			komoda_droga = true;
		}
	}

	void Ciagle(){
		LeweKolko.fillAmount += Time.deltaTime;
	}
	void Koniec(){
		LeweKolko.fillAmount = 0;
		komoda_droga = true;
	}
}
