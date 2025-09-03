using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemBoxPickup : MonoBehaviour
{

    public void OnCollisionEnter(Collision collision)
    {
        gameObject.SetActive(false);

        Invoke("itemBoxRespawn", 10f);
    }

    private void itemBoxRespawn()
    {
        gameObject.SetActive(true);
    }
 }