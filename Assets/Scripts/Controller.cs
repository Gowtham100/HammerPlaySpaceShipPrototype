using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{
    private Vector3 mousePosition;

    public float Speed;
    private float normalSpeed = 5f;
    public GameObject engine;
    private float boostSpeed = 17f;
    public GameObject Bullet;
    public GameObject Explosion;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Code for speed booster
        if (Input.GetKeyDown("left shift"))
        {
            Speed = boostSpeed;
        }
        else if (Input.GetKeyUp("left shift"))
        {
            Speed = normalSpeed;
        }
        Movement();

        //Shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, transform.position, transform.rotation);
        }

    }

    public void Movement()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float y = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        transform.position = new Vector3(transform.position.x + (Speed * x), transform.position.y + (Speed * y), -1f);

        if (x != 0 || y != 0)
        {
            Quaternion newRotation = transform.rotation;
            newRotation.SetLookRotation(new Vector3(x, y, 1f).normalized, Vector3.back);

            transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, .1f);
        }
    }
    
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag=="Ast")
        {
           Debug.Log("Ouch");
            Destroy(gameObject);
            Instantiate(Explosion, transform.position, transform.rotation);
        }
    }
   


    }

