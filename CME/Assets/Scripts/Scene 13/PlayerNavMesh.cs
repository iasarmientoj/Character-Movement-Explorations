using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{



    [SerializeField] private bool workWithTarget;
    [SerializeField] private Transform movePositionTransform;
    private NavMeshAgent navMeshAgent;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (workWithTarget)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                navMeshAgent.destination = movePositionTransform.position;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray movePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(movePosition, out var hitInfo))
                {
                    navMeshAgent.SetDestination(hitInfo.point);
                }
            }

        }

    }

}
