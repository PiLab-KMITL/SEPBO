using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEPBO_Trash : MonoBehaviour
{

	public string t_name;
	public int type;

	public int id;

	private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
		startPos = transform.position;

		if (GameObject.Find("OVRPlayerController") != null)
		{
			Physics.IgnoreCollision(GameObject.Find("OVRPlayerController").GetComponent<Collider>(), GetComponent<Collider>());
		}

	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void setToStartPo()
	{
		transform.position = startPos;
	}

	public string getTName()
	{
		return t_name;
	}
	public int getType()
	{
		return type;
	}
	public int getId()
	{
		return id;
	}
}
