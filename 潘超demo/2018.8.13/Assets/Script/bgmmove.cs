using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmmove : MonoBehaviour {


    //背景移动速度
    public float speed = 2f;
	void Start () {	}
	void Update () {
        //改变背景的坐标
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        //判断
        if (transform.position.y < -10f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 2 * 10f, transform.position.z);
         }
	}
}
