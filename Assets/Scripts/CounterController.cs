using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterController : MonoBehaviour
{
    [SerializeField] private InputReader _inputReader;
    [SerializeField] private Counter _counter;
    [SerializeField] private CounterView _counterView;

    private void OnEnable()
    {
        _inputReader.Clicked += _counter.ToggleCounting;
        _counter.ValueChanged += _counterView.ShowValue;
    }

    private void OnDisable()
    {
        _inputReader.Clicked -= _counter.ToggleCounting;
        _counter.ValueChanged -= _counterView.ShowValue;
    }
}
