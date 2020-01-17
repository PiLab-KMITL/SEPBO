using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEPBO_ReturnFloor : MonoBehaviour
{
	
	private void OnCollisionEnter(Collision collision)
	{
		SEPBO_Trash tresh = collision.gameObject.GetComponent<SEPBO_Trash>();
		tresh.setToStartPo();
	}
}
