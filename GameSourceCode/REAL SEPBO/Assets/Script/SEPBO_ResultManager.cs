using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SEPBO_ResultManager : MonoBehaviour
{

	private static int SCORE;

	private static SEPBO_ScoreType[] listTrash;

	//public Transform modelPosition;
	public Text resultBoard;
	public Text scroe;

	//public GameObject[] trashs;

    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("Result START!!");
		//
		if (listTrash != null)
		{

			

			for (int i = 0; i < listTrash.Length; i++)
			{

				//Instantiate(trashs[listTrash[i].id], modelPosition.position, Quaternion.identity);

				Debug.Log("name: " + listTrash[i].t_name + " All :" + listTrash[i].t_all + "DONE : " +listTrash[i].score);

				resultBoard.text += listTrash[i].t_name; //+ " All :" + listTrash[i].t_all + "DONE : " + listTrash[i].score + '\n';
				//for (int j = 0; j < (MaxNameRange - listTrash[i].t_name.Length + 1);j++)
				//{
					//resultBoard.text += "1";
				//}
				resultBoard.text += ":" + '\n';
				scroe.text += listTrash[i].score + " / " + listTrash[i].t_all + "\n";

			}
		}

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public static void AddScore(SEPBO_Trash trash)
	{
		if (listTrash != null && trash != null)
		{
			for (int i = 0; i < listTrash.Length; i++)
			{
				if (trash.t_name == listTrash[i].t_name)
				{
					Debug.Log("+111111");
					listTrash[i].score += 1;
				}
			}
		}
		SCORE++;
	}

	public static void setListTrash(SEPBO_ScoreType[] type)
	{
		listTrash = type;
	}

	public static int getScore()
	{
		return SCORE;
	}

	public static void ResetScore()
	{
		listTrash = null;
		SCORE = 0;
	}

}
