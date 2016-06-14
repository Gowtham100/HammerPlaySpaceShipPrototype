using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    private Rigidbody2D rb;
    public float Speed;
    // Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * Speed);
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
