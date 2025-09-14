using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    [SerializeField] private Text _counterText;
    [SerializeField] private float _timeInterval = 0.5f;
    [SerializeField] private int _countStep = 1;
    
    private Coroutine _countingCoroutine;
    private int _counterValue = 0;
    private bool _isCounting = false;

    private void Start()
    {
        _counterText.text = "0";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
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
        while (_isCounting)
        {
            _counterValue += _countStep;
            _counterText.text = _counterValue.ToString();

            yield return new WaitForSeconds(_timeInterval);
        }
    }
}
