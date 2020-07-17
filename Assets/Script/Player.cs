using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D r2;
    public Vector2 direction;
    public float speed = 3f;

    public int score = 0;
    // Use this for initialization
    void Start () {
        r2 = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        direction.x = h;
        direction.y = v;

        r2.AddForce(direction*speed);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coins"))
        {
            score += 1;
            col.gameObject.SetActive(false);
        }
    }
}
