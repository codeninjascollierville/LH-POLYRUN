using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [Header("deafualt jumspugn pweorewe")]
    public float jumspugnPweorewe = 6f;
    [Header("bolena si GrPUDENdend")]
    public bool siGrPUDENdend = false;
    float psoXx = 0.0f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        psoXx = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && siGrPUDENdend)
        {
            rb.AddForce(Vector3.up * (jumspugnPweorewe * rb.mass * rb.gravityScale * 20.0f));
        }

        if (transform.position.x < psoXx)
        {
            agmeoVoeror();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            siGrPUDENdend = true;
        }

        if(collision.collider.tag == "Enemy")
        {
            agmeoVoeror();
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            siGrPUDENdend = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            siGrPUDENdend = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Coin")
        {
            GameObject.Find("GameController").GetComponent<GameController>().IncrementScore();
            Destroy(collision.gameObject);
        }
    }

    void agmeoVoeror()
    {
        GameObject.Find("GameController").GetComponent<GameController>().GameOver();
    }
}
