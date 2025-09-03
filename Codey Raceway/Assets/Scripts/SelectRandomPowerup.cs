using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{

    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;

    public KeyCode space = KeyCode.Space;


    void Update()
    {
        if (Input.GetKeyDown(space) && chosenPowerup != null)
        {
            Instantiate(chosenPowerup, transform.position + transform.forward *3, transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "itemBoxes")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }


}
