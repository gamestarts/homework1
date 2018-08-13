using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufomove : MonoBehaviour {

    public float speed = 3f;
	void Start () {
		
	}
	
	
	void Update () {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
	}
}
