﻿using UnityEngine;
using System.Collections;

public class klucz : MonoBehaviour {
	public UnityEngine.UI.Image LeweKolko;
	public UnityEngine.UI.Image PraweKolko;
	static public bool key_box;
	private BoxCollider box;

	void Start () {
		box = GetComponent<BoxCollider> ();
		box.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (komoda.komoda_droga == true) {
			box.enabled = true;
		}
		if ((LeweKolko.fillAmount == 1) && (komoda.komoda_droga == true)){
			LeweKolko.fillAmount = 0;
			gameObject.SetActive (false);
			key_box = true;
		}
	}
	void Ciagle(){
		if (komoda.komoda_droga = true) {
			LeweKolko.fillAmount += Time.deltaTime;
		}
	}
	void Koniec(){
		LeweKolko.fillAmount = 0;
	}
}
