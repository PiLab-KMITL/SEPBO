using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEPBO_MapGenerator : MonoBehaviour
{

	public int LEVEL;

	public GameObject[] trashs;
	public GameObject PLAYER;
	private Vector3 center;

	private float posX = 0;
	private float posY = 0;

	private static SEPBO_ScoreType[] listTrash;

	// Start is called before the first frame update
	void Start()
    {
		center = transform.position;

		SEPBO_GameManager.setLEVLE(LEVEL);

		GenerateMap();

		SEPBO_ResultManager.setListTrash(listTrash);

		for (int i = 0;i < listTrash.Length;i++)
		{
			Debug.Log("name: " + listTrash[i].t_name + " All :" + listTrash[i].t_all);
		}
		SEPBO_GameManager.setSTATE(SEPBO_GameManager.PLAY);

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	void GenerateMap()
	{
		listTrash = new SEPBO_ScoreType[trashs.Length];

		posX = Random.Range(-5f, 5f);
		posY = Random.Range(-5f, 5f);
		for (int j = 0; j < trashs.Length; j++)
		{

			listTrash[j] = new SEPBO_ScoreType();

			listTrash[j].t_name = trashs[j].GetComponent<SEPBO_Trash>().getTName();
			listTrash[j].type = trashs[j].GetComponent<SEPBO_Trash>().getType();
			listTrash[j].id = trashs[j].GetComponent<SEPBO_Trash>().getId();

			for (int i = 0; i < 2; i++)
			{
				Instantiate(trashs[j], center + new Vector3(posX, 0, posY), Quaternion.identity);
				posX = Random.Range(-5f, 5f);
				posY = Random.Range(-5f, 5f);

				listTrash[j].t_all += 1; 

			}
		}
	}

}
