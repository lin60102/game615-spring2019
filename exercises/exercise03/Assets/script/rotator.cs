﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{

    void Update()
    {
 
        transform.Rotate(new Vector3(65, 60, 45) * Time.deltaTime);
    }
    
}