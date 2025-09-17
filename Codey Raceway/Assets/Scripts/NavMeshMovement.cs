using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class NavMeshMovement : MonoBehaviour
{
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = 0.1f;
        agent.destination = GameObject.FindGameObjectWithTag ("obstacles").transform.position;
        Debug.Log("finish"+ agent.destination);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(agent.pathStatus);
    }
}
