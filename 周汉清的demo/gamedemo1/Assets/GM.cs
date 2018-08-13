using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour {
    private bool isGameOver = false;
    public Spawner spawner;
    public Rotator rotator;


    // Use this for initialization
    void Start () {
		
	}
    public void GameOver()
    {
        if (!isGameOver)
        {
            isGameOver = true;
            spawner.enabled = false;
            rotator.enabled = false;

        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
