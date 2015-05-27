using UnityEngine;
using System.Collections;

public class półka : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Poczatek(){
		transform.position = new Vector3 (0, 0, 0);
		
	}
	void Ciagle(){
		Debug.Log ("ciagle");
	}
	void Koniec(){
		Debug.Log ("koniec");
	}
}
