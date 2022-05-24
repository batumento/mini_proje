using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;// istersek Scene'den ayarlayarak kameran�n pozisyonu ile targetin pozisyonunu ��kar�p offsete atayarak da yapabiliriz.
    [SerializeField] private float lerpSpeed;
    private void Start()
    {
       //offset = transform.position - target.position;
    }
    void Update()
    {
        Follow();
    }
    private void Follow()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * lerpSpeed);
    }
}
