using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{

    public GameObject objectThrown;
    public Vector3 offset;
    public int throwableCounter;
    public int enemysRemaining;
    public Text collectableCounter;




    void Start()
    {

    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            offset = transform.localScale.x * new Vector3(2, 0, 0);
            Vector3 throwablePosition = transform.position + offset;

            if (throwableCounter > 0)
            {

                Instantiate(objectThrown, throwablePosition, transform.rotation);
                throwableCounter -= 1;
                collectableCounter.text = throwableCounter.ToString();
            }
        }
    }


    // 1. Collect Ammo
    // 2. If theres ammo remaining,
    // 3. Shoot projectile by making projectile move
    // 4. Transform.position += Vector3.right
    // 5. If projectile collides with an enemy or wall, destroy itself
    // 6. If there is an enemy, it will destroy the enemy
    // 7. gameObject = itself
    // 8. collision.gameObject = object collided in collision




    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collectable")
        {
            throwableCounter += 1;

            collectableCounter.text = throwableCounter.ToString();
            Destroy(collision.gameObject);
        }
    }

}
