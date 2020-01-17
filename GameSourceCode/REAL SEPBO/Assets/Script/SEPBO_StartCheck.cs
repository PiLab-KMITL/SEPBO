using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEPBO_StartCheck : MonoBehaviour
{
	public SEPBO_GameManager gameManager;
	// Start is called before the first frame update
	void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
		
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Player")
		{
			Debug.Log("Game Start!!");
			gameManager.StartTimeCount();
			SEPBO_GameManager.setSTATE(SEPBO_GameManager.PLAY);
			Destroy(gameObject);
		}
		
	}

}
