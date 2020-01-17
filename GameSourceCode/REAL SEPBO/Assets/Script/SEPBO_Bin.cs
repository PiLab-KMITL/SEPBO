using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEPBO_Bin : MonoBehaviour
{

	public int type = 0; //Type of Tresh 0:general type 1:biodegradable 2:recycle 3:danger

	public TFCheck t_f_check;

	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

	private void OnCollisionEnter(Collision collision)
	{
		SEPBO_Trash tresh = collision.gameObject.GetComponent<SEPBO_Trash>();
		if (collision.gameObject.tag == "trash" && this.type == tresh.getType() )
		{
			t_f_check.setMat(t_f_check.getTMat());
			SEPBO_ResultManager.AddScore(tresh);
		}
		else
		{
			t_f_check.setMat(t_f_check.getFMat());
		}
		Destroy(collision.gameObject);

	}

	public int getType()
	{
		return this.type;
	}

	public void setType(int x)
	{
		this.type = x;
	}
}
