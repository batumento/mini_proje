using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("Player"))
        {
        }
    }
}
