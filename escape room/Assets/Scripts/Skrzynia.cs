using UnityEngine;
using System.Collections;

public class Skrzynia : MonoBehaviour {
	public UnityEngine.UI.Image LeweKolko;
	public UnityEngine.UI.Image PraweKolko;
	private Animator anim;
	private BoxCollider box;
	// Use this for initialization
	void Start () {
		anim = GetComponentInChildren<Animator>();
		box = GetComponent<BoxCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (LeweKolko.fillAmount == 1) {
			anim.SetTrigger ("Open");
			LeweKolko.fillAmount = 0;
			box.enabled=false;

		}
	}
	void Ciagle(){
		LeweKolko.fillAmount += Time.deltaTime;

	}
	void Koniec(){
		LeweKolko.fillAmount = 0;
		
	}
}
