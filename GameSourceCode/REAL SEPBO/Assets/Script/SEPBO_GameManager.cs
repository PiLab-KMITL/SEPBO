using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SEPBO_GameManager : MonoBehaviour
{
	//STATE
	private static string STATE = "IDLE";

	public static readonly string IDLE = "IDLE";
	public static readonly string TUTORIAL = "TUTORIAL";
	public static readonly string PLAY = "PLAY";
	public static readonly string RESULT = "RESULT";
	//

	//LEVEL
	private static int nowLevel = 0;
	public static readonly int LV1 = 1;
	public static readonly int LV2 = 2;
	public static readonly int LV3 = 3;
	//

	//TIME
	private static int TIME = 180;

	//
	public string nextLevelText = "Stage";

	// Start is called before the first frame update
	void Start()
    {
		print("Game Manager START!!!");
		print("GAME LEVEL : " + SEPBO_GameManager.getLEVEL());
    }

    // Update is called once per frame
    void Update()
    {
		if (SEPBO_GameManager.getTIME() == 0)
		{
			GoToScene("ResultScene");
			SEPBO_GameManager.setSTATE(SEPBO_GameManager.RESULT);
		}
		if (GameObject.FindGameObjectsWithTag("trash").Length == 0 && SEPBO_GameManager.getSTATE() == SEPBO_GameManager.PLAY)
		{
			GoToScene("ResultScene");
			SEPBO_GameManager.setSTATE(SEPBO_GameManager.RESULT);
		}
		Debug.Log("Count trash:"+GameObject.FindGameObjectsWithTag("trash").Length);
		Debug.Log(SEPBO_GameManager.getSTATE());
    }

	//STATE
	public static string getSTATE()
	{
		return STATE;
	}
	public static void setSTATE(string state)
	{
		STATE = state;
	}

	//LEVEL
	public static int getLEVEL()
	{
		return nowLevel;
	}
	public static void setLEVLE(int level)
	{
		nowLevel = level;
	}

	//TIME
	public static int getTIME()
	{
		return TIME;
	}
	public static void setTIME(int time)
	{
		TIME = time;
		if (TIME <= 0)
		{
			TIME = 0;
		}
	}

	static IEnumerator StartCountDown()
	{
		while (SEPBO_GameManager.getTIME() != 0)
		{
			yield return new WaitForSeconds(1);
			SEPBO_GameManager.setTIME(SEPBO_GameManager.getTIME() - 1);

			//Debug.Log("TIME: " + SEPBO_GameManager.getTIME());
		}
	}

	public void StartTimeCount()
	{
		StartCoroutine(StartCountDown());
	}
	//

	//SCENE CONTROLL
	public void GoToScene(string sceneName)
	{
		Debug.Log("Go to Scene "+ sceneName);

		SEPBO_GameManager.setTIME(180);

		SceneManager.LoadScene(sceneName);
	}
	public void doExit()
	{
		Debug.Log("Exit Game");
		Application.Quit();
	}
	//
	public void nextLevel()
	{
		SEPBO_ResultManager.ResetScore();
		GoToScene(nextLevelText + (SEPBO_GameManager.nowLevel+1));
	}
}
