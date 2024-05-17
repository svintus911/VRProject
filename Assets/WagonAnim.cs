using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WagonAnim : MonoBehaviour
{
    public Vector3 pointA = new Vector3(-5.36f, -0.02f, -1.28f);
    public Vector3 pointB = new Vector3(-1.36f, -0.02f, -1.28f);
    public float speed = 1.0f;

    private float journeyLength;
    private float startTime;

    void Start()
    {
        // Устанавливаем начальную позицию объекта в точку A
        transform.position = pointA;

        // Рассчитываем расстояние между точками A и B
        journeyLength = Vector3.Distance(pointA, pointB);

        // Запоминаем время начала движения
        startTime = Time.time;
    }

    void Update()
    {
        // Вычисляем, сколько времени прошло с начала движения
        float distCovered = (Time.time - startTime) * speed;

        // Определяем долю пройденного пути
        float fractionOfJourney = distCovered / journeyLength;

        // Перемещаем объект с помощью линейной интерполяции (Lerp)
        transform.position = Vector3.Lerp(pointA, pointB, fractionOfJourney);

        // Если объект достиг точки B, можно перезапустить движение (опционально)
        //if (fractionOfJourney >= 1.0f)
        //{
        //    startTime = Time.time;
        //    Vector3 temp = pointA;
        //    pointA = pointB;
        //    pointB = temp;
        //}
    }
}
