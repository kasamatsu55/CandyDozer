using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0, 0.1f); //移動量
        transform.Rotate(0, 2f, 0); //y軸回転
        transform.position = new Vector3(3f*Mathf.Cos(Time.time*3f), Mathf.Sin(Time.time*3f), Time.time*5f);
    }
}
