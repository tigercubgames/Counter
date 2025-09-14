using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputReader : MonoBehaviour
{
    public UnityEvent MouseClicked;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseClicked.Invoke();
        }
    }
}
