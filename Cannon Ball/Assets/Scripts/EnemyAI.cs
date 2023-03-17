using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] wayPoints;
    int wayPointIndex;
    Vector3 target;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        UpdateDestination();
    }
    private void Update()
    {
        if(Vector3.Distance(transform.position, target) < 1)
        {

            IterateWaypoint();
            UpdateDestination();
        }
    }
    void UpdateDestination()
    {
        target = wayPoints[wayPointIndex].position;
        agent.SetDestination(target);
    }
    void IterateWaypoint()
    {
        wayPointIndex++;
        if (wayPointIndex == wayPoints.Length)
        {
            wayPointIndex = 0;
        }
    }
}
