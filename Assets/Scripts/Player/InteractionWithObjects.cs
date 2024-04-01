using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionWithObjects : MonoBehaviour
{
    [SerializeField] private Transform Marker;
	[SerializeField] private int Distance;
	
	void FixedUpdate()
	{
		Ray ray = new Ray(transform.position, transform.forward);
		RaycastHit hit;
		if(Physics.Raycast(ray, out hit, Distance) && Input.GetMouseButtonDown(0))
		{
			if(hit.collider.gameObject.GetComponent<Door>())
			{
				hit.collider.gameObject.GetComponent<Door>().ChangeStateDoor();
			}
		}
	}
}
