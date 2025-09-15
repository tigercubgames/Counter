using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputReader : MonoBehaviour
{
    private int _buttonNumber = 0;
    public event Action Clicked;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(_buttonNumber))
        {
            Clicked?.Invoke();
        }
    }
}
