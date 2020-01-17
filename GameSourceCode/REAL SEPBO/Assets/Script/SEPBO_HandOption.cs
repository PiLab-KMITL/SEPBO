using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEPBO_HandOption : MonoBehaviour
{

	public DistanceGrabber Hand;
	public string HandText;
	public SEPBO_PlayerUI PlayerUI;
	private Collider selectTrash;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		selectTrash = Hand.getM_targetCollider();

		if (selectTrash != null)
		{
			Debug.Log(Hand.getM_targetCollider().GetComponent<SEPBO_Trash>().getTName());
			PlayerUI.setSymbolActive(HandText, selectTrash.GetComponent<SEPBO_Trash>().getType(), true);
		}
		else
		{
			PlayerUI.setSymbolActive(HandText, -1, false);
		}
    }
}
