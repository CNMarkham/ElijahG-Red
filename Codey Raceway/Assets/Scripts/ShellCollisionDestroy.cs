using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellCollisionDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("trigger " + other.gameObject.name);
        if (other.gameObject.tag == "obstacles")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);

            //Debug.Log("Collide");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("test " + collision.gameObject.name);
        if (collision.gameObject.tag == "obstacles")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            //Debug.Log("Collide");
        }

    }

}
