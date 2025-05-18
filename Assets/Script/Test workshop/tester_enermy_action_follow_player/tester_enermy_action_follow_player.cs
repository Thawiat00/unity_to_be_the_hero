using UnityEngine;
using UnityEngine.AI;

public class tester_enermy_action_follow_player : MonoBehaviour
{

    public Transform goal;
    [SerializeField] NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    private void Update()
    {
     
        agent.destination = goal.position;
    }

}
