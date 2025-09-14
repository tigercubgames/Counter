using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Text _counterText;
    
    public void ShowValue(int value)
    {
        _counterText.text = value.ToString();
    }
}
