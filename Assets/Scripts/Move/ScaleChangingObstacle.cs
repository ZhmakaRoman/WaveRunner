using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChangingObstacle : MonoBehaviour
{
    [SerializeField]
    private float min = 0.5f;
    [SerializeField]
    private float max = 2f ;
    [SerializeField]
    private float _speed = 2f;

    private float _currentTime;
    
    void Update()
    {
       // Значение _currentTime увеличивается на Time.deltaTime, что означает количество секунд, прошедшее с прошлого кадра.
        _currentTime += Time.deltaTime;
        //Переменная progres вычисляет текущий прогресс анимации от 0 до 1
        var progres = _currentTime / _speed;
        //Затем, используя метод Mathf.PingPong(), вычисляется значение масштаба на основе текущего прогресса и значений min и max.
        transform.localScale = new Vector2(Mathf.PingPong(progres, max - min) + min,Mathf.PingPong(progres, max-min)+min);

    }
}
