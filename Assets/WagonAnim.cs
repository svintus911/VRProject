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
        // ������������� ��������� ������� ������� � ����� A
        transform.position = pointA;

        // ������������ ���������� ����� ������� A � B
        journeyLength = Vector3.Distance(pointA, pointB);

        // ���������� ����� ������ ��������
        startTime = Time.time;
    }

    void Update()
    {
        // ���������, ������� ������� ������ � ������ ��������
        float distCovered = (Time.time - startTime) * speed;

        // ���������� ���� ����������� ����
        float fractionOfJourney = distCovered / journeyLength;

        // ���������� ������ � ������� �������� ������������ (Lerp)
        transform.position = Vector3.Lerp(pointA, pointB, fractionOfJourney);

        // ���� ������ ������ ����� B, ����� ������������� �������� (�����������)
        //if (fractionOfJourney >= 1.0f)
        //{
        //    startTime = Time.time;
        //    Vector3 temp = pointA;
        //    pointA = pointB;
        //    pointB = temp;
        //}
    }
}
