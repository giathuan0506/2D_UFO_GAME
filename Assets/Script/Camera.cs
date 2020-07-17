using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

    public Vector3 offset;
    public GameObject player;
    // Use this for initialization
    void Start()
    {
        offset = this.transform.position - player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = player.transform.position + offset;
    }
}
