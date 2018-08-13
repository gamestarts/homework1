﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;

    }

    // Update is called once per frame

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Rotator")
        {
            rb.velocity = Vector2.zero;
            Score.scoreValue++;
            transform.SetParent(col.transform);
        }
        else if (col.tag == "Pin")
        {
            GameObject.FindObjectOfType<GM>().GameOver();
        }

    }
}
