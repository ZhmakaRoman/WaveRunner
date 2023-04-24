using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingObstacle : MonoBehaviour
{
    private float _currentTime;
    //Амплитудой смещение
    [SerializeField]
    private float _amplitude = 0.25f;
    //частота движения
    [SerializeField]
    private float frequency = 2f;
    //значения смещения
    private float offSet;
    //начальное положение
    private Vector3 _startPosition;
    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        //время после кадров
       _currentTime += Time.deltaTime;
           //вычесляем смещение
           offSet = _amplitude * Mathf.Sin(_currentTime * frequency);
           //меняем положение
           transform.position = _startPosition + new Vector3(0, offSet, 0);


    }
}
