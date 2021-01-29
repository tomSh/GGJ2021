﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    private Vector3 _scale;

    private void Awake()
    {
        _scale = transform.localScale;
    }
    

    public void HoveOn()
    {
        transform.localScale = _scale * 1.5f;
    }
    
    
    public void HoveOff() {
        transform.localScale = _scale;
    }
     
}
