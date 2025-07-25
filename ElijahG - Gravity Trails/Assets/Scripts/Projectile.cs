using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// sword prefab uses this script to move

public class Projectile : MonoBehaviour
{

    public Throwable direction;
    public Teleport teleport;
    public float speed;
    private EnemyUI enemyUI;
    public int enemysRemaining;


    void Start()
    {
        // finds the direction of the player's throwable and stores it in "direction" variable
        direction = GameObject.FindGameObjectWithTag("Player").GetComponent<Throwable>();
        enemyUI = GameObject.FindGameObjectWithTag("UI").GetComponent<EnemyUI>();

        teleport = FindFirstObjectByType<Teleport>();
        //Debug.Log(direction);
    }

    // checks if it collides with any 2D object
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        Debug.Log(enemysRemaining);


        // collides with enemy
        if (collision.gameObject.tag == "Enemy")
        {

            enemyUI.UpdateText();

            teleport.enemyCount--;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }



    void Update()
    {
        transform.position += direction.offset * Time.deltaTime * speed;
    }
}
