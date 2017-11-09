using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour {

	// Use this for initialization
	void Start () {
		

		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject Camera = GameObject.Find("Main Camera");
		if (this.transform.position.z < Camera.transform.position.z) {
			Destroy (this.gameObject);
		}
		
	}
}
