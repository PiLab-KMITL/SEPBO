using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TFCheck : MonoBehaviour
{

	public Material normal;
	public Material T_mat; // For True
	public Material F_mat; // For False

	private bool isNormal = true;

	// Start is called before the first frame update
	void Start()
    {
		setMat(normal);
    }

    // Update is called once per frame
    void Update()
    {
		if (!isNormal)
		{
			isNormal = true;
			StartCoroutine(setBackNormal());
		}
	}

	IEnumerator setBackNormal()
	{
		yield return new WaitForSeconds(1);
		if (isNormal)
		{
			setMat(normal);
		}
	}

	public void setMat(Material mat)
	{
		Renderer rend = GetComponent<Renderer>();

		if (mat != this.normal)
		{
			isNormal = false;
		}

		if (rend != null)
		{
			rend.material = mat;
		}
	}

	public Material getNMat()
	{
		return this.normal;
	}

	public Material getTMat()
	{
		return this.T_mat;
	}

	public Material getFMat()
	{
		return this.F_mat;
	}
}
