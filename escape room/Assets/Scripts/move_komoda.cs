using UnityEngine;
using System.Collections;

public class move_komoda : MonoBehaviour {
	public Vector3 position;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (komoda.komoda_droga == true) {
			transform.position = new Vector3 (-3, transform.position.y, transform.position.z);
		}
	}
}
