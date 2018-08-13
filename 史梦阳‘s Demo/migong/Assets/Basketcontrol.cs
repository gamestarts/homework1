using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Basketcontrol : MonoBehaviour {
    [Header("水平方向")]
    public float moveX;
    [Header("垂直方向")]
    public float moveY;
    [Header("推力")]
    public float push;
    Rigidbody2D rb;
    [Header("分数文字UI")]
    public Text countText;
    [Header("过关文字UI")]
    public Text winText;
    int score = 0;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        winText.text = "";
        setScoreText();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveX, moveY);
        rb.AddForce(push * movement);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(name+"触发了"+other.name);
        if (other.CompareTag("apple"))
        {
            other.gameObject.SetActive(false);
            score = score + 1;
            setScoreText();
        }
    }
    void setScoreText() {
        countText.text = "目前分数" + score.ToString();
        if (score >= 8)
        {
            winText.text = "你赢了";
        }
    }
}
