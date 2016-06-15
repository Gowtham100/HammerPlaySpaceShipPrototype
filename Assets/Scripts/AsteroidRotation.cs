﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class AsteroidRotation : MonoBehaviour
{
    public GameObject Explosion;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 180 * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {

            gameObject.SetActive(false);
            Instantiate(Explosion, transform.position, transform.rotation);
            SceneManager.LoadScene(1);

        }
       

    }

}
