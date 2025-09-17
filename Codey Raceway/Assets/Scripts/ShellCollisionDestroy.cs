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
        if (other.gameObject. == "obstacles")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Debug.Log("Collide");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("test");
        if (collision.gameObject.tag == "obstacles")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Debug.Log("Collide");
        }

    }

}
