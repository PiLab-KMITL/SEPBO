using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashSpawner : MonoBehaviour
{
	public GameObject[] trashs;
	bool stop = false;
	// Start is called before the first frame update
	void Start()
    {
		StartCoroutine(countDown());
	}

    // Update is called once per frame
    void Update()
    {
		if (!stop)
		{
			for (int i = 0; i < trashs.Length; i++)
			{
				GameObject memo = Instantiate(trashs[i], transform.position, transform.rotation);
			}
		}
	}

	IEnumerator countDown()
	{
		while (true)
		{
			stop = false;
			yield return new WaitForSeconds(1);
			stop = true;
			yield return new WaitForSeconds(3);

			for (int i = 0; i < GameObject.FindGameObjectsWithTag("trash").Length; i++)
			{
				Destroy(GameObject.FindGameObjectsWithTag("trash")[i]);
			}

			yield return new WaitForSeconds(1);
		}
	}

}
