using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMotor : MonoBehaviour {

    Transform target;
    NavMeshAgent agent;

	// Use this for initialization
	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
    private void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
        if (Vector3.Distance(transform.position, target.transform.position) < 4)
        {
            target = null;
        }
    }

    public void MoveToPoint (Vector3 point)
    {
            agent.SetDestination(point);
    }

    public void FollowTarget(Interactable newTarget)
    {
        target = newTarget.transform;
    }

    public void StopFollowingTarget()
    {
        target = null;
    }
}
