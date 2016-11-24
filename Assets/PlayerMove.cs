using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if (Input.GetKey("up")) {
			transform.position = new Vector3(pos.x , pos.y , pos.z + 0.1f);
		}
		if (Input.GetKey("down")) {
			transform.position = new Vector3(pos.x , pos.y , pos.z - 0.1f);
		}
		if (Input.GetKey("right")) {
			transform.position = new Vector3(pos.x + 0.1f , pos.y, pos.z );

		}
		if (Input.GetKey ("left")) {
			transform.position = new Vector3(pos.x - 0.1f, pos.y, pos.z );

		}
	}
}
