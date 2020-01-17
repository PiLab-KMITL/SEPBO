using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEPBO_PlayerUI : MonoBehaviour
{

	public GameObject TIME_TEXT;
	public GameObject SCORE_TEXT;

	public Image LeftSymbol;
	public Image RightSymbol;

	public Material[] Symbols;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		if(TIME_TEXT != null)
			TIME_TEXT.GetComponent<Text>().text = "TIME: " + SEPBO_GameManager.getTIME();
		if (SCORE_TEXT != null)
			SCORE_TEXT.GetComponent<Text>().text = "SCORE: " + SEPBO_ResultManager.getScore();
	}

	public void setSymbolActive(string hand, int type, bool state)
	{
		if (hand == "left")
		{
			LeftSymbol.enabled = state;
			if (type != -1)
			{
				LeftSymbol.material = Symbols[type];
			}
		}
		if (hand == "right")
		{
			RightSymbol.enabled = state;
			if (type != -1)
			{
				RightSymbol.material = Symbols[type];
			}
		}
	}

}
