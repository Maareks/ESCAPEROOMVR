using UnityEngine;
using System.Collections;

public class Skrzynia : MonoBehaviour {
	public UnityEngine.UI.Image LeweKolko;
	public UnityEngine.UI.Image PraweKolko;
	private Animator anim;
	private BoxCollider box;

	void Start () {
			anim = GetComponentInChildren<Animator>();
			box = GetComponent<BoxCollider> ();
	}

	void Update () {
		if ((LeweKolko.fillAmount == 1) && (klucz.key_box == true)) {
			anim.SetTrigger ("Open");
			LeweKolko.fillAmount = 0;
			box.enabled=false;
		}
	}
	void Ciagle(){
		if (klucz.key_box == true) {
			LeweKolko.fillAmount += Time.deltaTime;
		}
	}
	void Koniec(){
		LeweKolko.fillAmount = 0;	
	}
}
