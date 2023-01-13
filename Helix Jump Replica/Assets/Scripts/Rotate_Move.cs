using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Move : MonoBehaviour
{

    public float rotateSpeed;
    private float moveX;

    void FixedUpdate()
    {

        moveX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0)) //Left Cliclk
        {
            transform.Rotate(0f, moveX * rotateSpeed * Time.deltaTime, 0f);
        }

    }
    
}
