using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Door : MonoBehaviour
{
	public bool isOpened;
	[SerializeField] private Animator animator;

	public void ChangeStateDoor()
	{
		isOpened = !isOpened;
		animator.SetBool("_isOpened", isOpened);
	}
	public GameObject EnterPosition;
	public GameObject ExitPosition;
}
