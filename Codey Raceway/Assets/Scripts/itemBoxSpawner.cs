using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxSpawner : MonoBehaviour
{
    public GameObject itemBox;

    public int numberOfBoxes;

    public int modifyXPosition;
    public int modifyZPosition;

    void Start()
    {
        // For loops
        // The standard for loop has 3 components inside its paranthesis()
        // They have the initializer, the condition and the increment, respectively
        // The initializer state where the for loop begins,
        // The condition says the condition where for loop ends
        // The increment state how much the for loop increase by each time.
        for (int i = 0; i < numberOfBoxes; i += 1)
        {
            GameObject itemBoxClone = Instantiate(
                itemBox,
                new Vector3(
                    transform.position.x + modifyXPosition * i,
                    transform.position.y,
                    transform.position.z + modifyZPosition * i
                    ),
                transform.rotation);
        }
    }


}
