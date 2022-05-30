using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMoneyManager : MonoBehaviour
{
    [SerializeField] Mesh changeMesh;
    [SerializeField] Mesh changeMesh2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collected"))
        {
            Change(other);
        }
        else if (other.gameObject.CompareTag("Collected2"))
        {
            Change2(other);
        }
    }
    private void Change(Collider _other)
    {
        _other.gameObject.GetComponent<MeshFilter>().mesh = changeMesh;
        _other.gameObject.tag = "Collected2";
    }
    private void Change2(Collider _other)
    {
        _other.gameObject.GetComponent<MeshFilter>().mesh = changeMesh2;
        _other.gameObject.tag = "Collected3";
    }
}
