using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEPBO_TutorialCheckBox : MonoBehaviour
{

	[SerializeField] public Image img;
	//
	 void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			img.enabled = true;
		}
	}

	 void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			img.enabled = false;
		}
	}
}
