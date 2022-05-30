using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    ATMRush aTMRush;
    private void Awake()
    {
        aTMRush = Object.FindObjectOfType<ATMRush>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            for (int i = aTMRush.moneys.IndexOf(other.gameObject); i < aTMRush.moneys.Count; i++)
            {
                aTMRush.moneys[i].transform.parent = null;
                aTMRush.moneys[i].transform.localPosition = Vector3.zero;
                aTMRush.moneys.Remove(aTMRush.moneys[i]);
            }
        }
        if (other.gameObject.CompareTag("Collected2"))
        {
            for (int i = aTMRush.moneys.IndexOf(other.gameObject); i < aTMRush.moneys.Count; i++)
            {
                aTMRush.moneys [i].transform.parent = null;
                aTMRush.moneys[i].transform.localPosition = Vector3.zero;
                aTMRush.moneys.Remove(aTMRush.moneys[i]);
            }
        }
        if (other.gameObject.CompareTag("Collected3"))
        {
            for (int i = aTMRush.moneys.IndexOf(other.gameObject); i < aTMRush.moneys.Count; i++)
            {
                aTMRush.moneys[i].transform.parent = null;
                aTMRush.moneys[i].transform.localPosition = Vector3.zero;
                aTMRush.moneys.Remove(aTMRush.moneys[i]);
            }
        }
        if (other.gameObject.CompareTag("Player"))
        {
            return;
        }
    }
}
