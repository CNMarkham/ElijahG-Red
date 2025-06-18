using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed;
    public int direction = 1;

    public int maximumXPosition;
    public int minimumXPosition;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

    private void FixedUpdate()
    {
        if (transform.position.x <= minimumXPosition || transform.position.x >= maximumXPosition)
        {

            speed *= -1;
        float newXScale = transform.localScale.x;
        float newYScale = transform.localScale.y;
        float newZScale = transform.localScale.z;
        transform.localScale = new Vector3(newXScale *-1, newYScale, newZScale);

        }

        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;

        Vector3 newPosition = new Vector3(newXPosition, newYPosition, -4);
        transform.position = newPosition;

    }


}
