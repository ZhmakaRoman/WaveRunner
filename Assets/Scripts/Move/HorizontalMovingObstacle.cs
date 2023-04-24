using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMovingObstacle : MonoBehaviour
{
    [SerializeField]
    private float _length = 6f;

    private float _current;
    private void Update()
    {
        //Переменная position содержит текущую позицию объекта, на котором находится данный компонент.
        var position = transform.position;
       
       //В данном случае используется Time.time, что позволяет создавать эффект бесконечного движения объекта слева на право.
       //Значение аргумента 6.0f определяет максимальное значение, а -2.5f - середину между крайними значениями.
        position.x = Mathf.PingPong(Time.time, _length) - 2.5f;
        transform.position = position;
      
       
    }
    
    
}
