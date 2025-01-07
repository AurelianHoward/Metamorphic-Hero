using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] Transform Destination;
    NavMeshAgent navMeshAgent;
    GameObject VaultLocation;
    void Start()
    {
        VaultLocation = GameObject.FindGameObjectWithTag("Player");
        navMeshAgent = GetComponent<NavMeshAgent>();
        if (Destination == null)
        {
            Destination = VaultLocation.transform;
        }
        Vector3 targetVector = Destination.position;
        navMeshAgent.SetDestination(targetVector);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
