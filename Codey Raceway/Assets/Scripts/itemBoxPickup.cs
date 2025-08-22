using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxPickup : MonoBehaviour
{
    public float showTime;
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
        gameObject.SetActive(false);

        Invoke("show", showTime);
    }

    public void show()
    {

    }
 }
