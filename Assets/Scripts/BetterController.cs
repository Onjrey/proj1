using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterController : MonoBehaviour
{
    public int speed = 20;
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        { 
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed); 
        }
    }
}
