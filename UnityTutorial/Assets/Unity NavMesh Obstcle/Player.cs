using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private RaycastHit rayCastHit;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray,out rayCastHit, Mathf.Infinity))
        {
            navMeshAgent.SetDestination(rayCastHit.point);
        }
    }
}
