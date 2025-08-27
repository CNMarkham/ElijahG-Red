using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    public float rotateSpeed = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("itemBoxRespawn", 10f);
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(transform.position*rotateSpeed);
    }
}
