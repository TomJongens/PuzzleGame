﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch4 : MonoBehaviour
{
   public static int clickTime = 0;

    public GameObject rightDegree;
    public GameObject leftDegree;
    public static bool sw4  = true;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    private void OnMouseDown()
    {
        clickTime++;
        
        if(clickTime % 2 == 0 )
        {
            rightDegree.transform.Rotate(0,0,20f, Space.World);
            leftDegree.transform.Rotate(0,0,15f, Space.World);
            this.transform.Rotate(45.0f, 0, 0.0f, Space.World);
            sw4 = true;
        }
        if(clickTime%2 == 1 )
        {   
            rightDegree.transform.Rotate(0,0,-20f, Space.World);
            leftDegree.transform.Rotate(0,0,-15f, Space.World);
            this.transform.Rotate(-45.0f, 0, 0.0f, Space.World);
            sw4 = false;
        }
    }
}
