using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            avatarRigidbody.gravityScale *= -1;
            Vector3 newDirection = new Vector3(transform.localScale.x, transform.localScale.y * -1, transform.localScale.z);
            transform.localScale = newDirection;
        }
    }
}
