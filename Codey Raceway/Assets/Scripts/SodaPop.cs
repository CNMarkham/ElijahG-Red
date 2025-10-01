using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SodaPop : MonoBehaviour
{

    public float Speed = 100f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("soda pop");
            CodeyMove cm = collision.gameObject.GetComponent<CodeyMove>();
            cm.SpeedBoost();
            Destroy(gameObject);
        }

    }
}
