using UnityEngine;
using UnityEngine.AI;

public class MoveToObject : MonoBehaviour
{
    public GameObject moveToObject;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = moveToObject.transform.position;
    }
}
