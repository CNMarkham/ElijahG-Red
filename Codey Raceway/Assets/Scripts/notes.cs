using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes : MonoBehaviour
{
    public GameObject item;
    public GameObject player;
    public GameObject topping;
    public Material toppingMaterial;

    // accessor - public, private, protected
    // type - int, Vector3, GameObject...
    // name - ___



    // VARIABLE - containers of data that can be changed
    // Accessor
    // Type - the type of variable
    // Name - the name of the variable

    // FUNCTION - Instructions
    // accessor
    // type - return type - what type of value will the function gives back-
    // if it is void, it does not return anything.
    // Name - the name of the function
    // Parameters - variable modifier that are used to costomize the function/instruction

    public void CustomizeIcecream(GameObject iceCream)
    {
        iceCream.GetComponentInChildren<MeshRenderer>().material=toppingMaterial;
    
    }

    private void Start()
    {
        for (int i = -2; i <= 2; i++)
        {
            CustomizeIcecream(item);
            Instantiate(item, new Vector3(i, 1, 0), Quaternion.identity);        }


        // instantiate function
        // spawns the item in the parameter in the game
        // 1st variation, spawns the object at the world's origin
        // Instantiate(item);
        // 2nd variation, spawns the object using the transform of the object in the 2nd parameter
        // Instantiate(item,player.transform);
        // 3rd variation, spawns the object using a custom position and a custom rotation
        // Instantiate(item, new Vector3(-29,11,172), Quaternion.identity);
    }

}
