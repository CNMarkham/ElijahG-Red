using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Projectile : MonoBehaviour
{

    public Throwable direction;
    public float speed;


    void Start()
    {

        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        Debug.Log(direction);
    }

    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }



    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
}
