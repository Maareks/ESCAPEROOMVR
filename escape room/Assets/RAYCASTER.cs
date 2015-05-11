using UnityEngine;
using System.Collections;

public class RAYCASTER : MonoBehaviour {

	private RaycastHit hit;
	private Collider poprzedniCol=null;//RAycast
	// Use this for initialization
	void Start () {
	
	}

	
	// Update is called once per frame
	void Update () {
		//Debug.Log (poprzedniCol);
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast (transform.position, fwd, out hit)) {
			if (hit.collider != poprzedniCol) {
				if (poprzedniCol != null)
					poprzedniCol.SendMessage ("Koniec", SendMessageOptions.DontRequireReceiver);
				poprzedniCol = hit.collider;

				if (poprzedniCol != null)
					poprzedniCol.SendMessage ("Poczatek", SendMessageOptions.DontRequireReceiver);


			} else {
				poprzedniCol.SendMessage ("Ciagle", SendMessageOptions.DontRequireReceiver);
			}
		} else {
			if (poprzedniCol != null)
				poprzedniCol.SendMessage ("Koniec", SendMessageOptions.DontRequireReceiver);
			poprzedniCol=null;
		}


	}
}
