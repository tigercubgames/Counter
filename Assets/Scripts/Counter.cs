using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    private const int StartValue = 0;
    
    [SerializeField] private float _timeInterval = 0.5f;
    [SerializeField] private int _countStep = 1;
    
    private Coroutine _countingCoroutine;
    private int _counterValue = 0;
    private bool _isCounting = false;
    
    public event Action<int> ValueChanged;

    public void ToggleCounting()
    {
        if (_isCounting)
        {
            DisableCounter();
        }
        else
        {
            EnableCounter();
        }
    }
    
    private void EnableCounter()
    {
        _isCounting = true;
        _countingCoroutine = StartCoroutine(Counting());
    }
    
    private void DisableCounter()
    {
        _isCounting = false;
        
        if (_countingCoroutine != null)
        {
            StopCoroutine(_countingCoroutine);
            _countingCoroutine = null;
        }
    }

    private IEnumerator Counting()
    {
        WaitForSeconds wait = new WaitForSeconds(_timeInterval);
        
        while (_isCounting)
        {
            _counterValue += _countStep;
            ValueChanged?.Invoke(_counterValue);

            yield return wait;
        }
    }
}
