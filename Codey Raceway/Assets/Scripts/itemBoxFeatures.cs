using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxFeatures : MonoBehaviour
{
    public float rotateSpeed = 0.001f;

    void Update()
    {
        gameObject.transform.Rotate(transform.position*rotateSpeed);
    }
}
