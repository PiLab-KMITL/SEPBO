using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour
{
    float direction = 1f;
    float position = 0f;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > position + 5)
        {
            direction = -1f;
        }
        if (transform.position.x < position - 5)
        {
            direction = 1f;
        }
        transform.position += new Vector3(1f * direction * Time.deltaTime, 0, 0);
        //print(position);
        //print(transform.position);
    }
}
