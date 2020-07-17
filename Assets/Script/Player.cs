using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    public Rigidbody2D r2;
    public Vector2 direction;
    public float speed = 100f;

    public int score = 0;

    public Text scoretext;
    public Text wintext;

    // Use this for initialization
    void Start () {
        setscoreText();
        r2 = GetComponent<Rigidbody2D>();
        wintext.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        direction.x = h;
        direction.y = v;

        r2.AddForce((direction.normalized*speed)*Time.deltaTime/0.5f);

        if (score >= 6)
            wintext.text = "YOU WIN !!";
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coins"))
        {
            score += 1;
            col.gameObject.SetActive(false);
            setscoreText();
        }
    }

    void setscoreText()
    {
        scoretext.text = "Score: " + score.ToString();
    }
}
