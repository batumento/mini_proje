using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;// istersek Scene'den ayarlayarak kameranýn pozisyonu ile targetin pozisyonunu çýkarýp offsete atayarak da yapabiliriz.
    [SerializeField] private float lerpSpeed;
    private void Start()
    {
       //offset = transform.position - target.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * lerpSpeed);
    }
}
