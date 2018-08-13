using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo : MonoBehaviour {

    public float speed = 10f;

    public float rate = 3f;
    public GameObject ufoo;

	void Start () {
        start();
	}


    public void scufoo()
    {
        GameObject.Instantiate(ufoo, transform.position, Quaternion.identity);


    }

    public void start()
    {
        InvokeRepeating("scufoo", 1, rate);

    }
}
