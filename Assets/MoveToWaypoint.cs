using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;

public class MoveToWaypoint : MonoBehaviour
{
    public Transform[] points;
    private NavMeshAgent agent;
    private int destinationIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       agent = GetComponent<NavMeshAgent>();

        GotoNextPoint();
    }

    // Update is called once per frame
    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            GotoNextPoint();
        }
    }
    void GotoNextPoint() 
    {
        if (points.Length == 0)
        {
            return;
        }

        agent.destination = points[destinationIndex].position;
        destinationIndex = (destinationIndex + 1) % points.Length;

    }
}
