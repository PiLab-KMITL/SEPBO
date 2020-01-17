using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolTrack : MonoBehaviour
{
	// Start is called before the first frame update

	public GameObject camera;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		transform.LookAt(transform.position + camera.transform.rotation * Vector3.forward, camera.transform.rotation * Vector3.up);
		//transform.LookAt(camera.transform, Vector3.up);

	}
}
