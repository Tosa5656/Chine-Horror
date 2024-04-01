using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveControll : MonoBehaviour
{
	[SerializeField] private NavMeshAgent agent;
	
	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
		{
			if(hit.collider.gameObject.GetComponent<Door>())
			{
				DoorInteract(hit.collider.gameObject.GetComponent<Door>());
			}
		}
	}
	
	void DoorInteract(Door door)
	{
		if(Vector3.Distance(transform.position, door.EnterPosition.transform.position) < Vector3.Distance(transform.position, door.ExitPosition.transform.position))
		{
			agent.destination = door.EnterPosition.transform.position;
		}
		else
		{
			agent.destination = door.ExitPosition.transform.position;
		}
	}
}
