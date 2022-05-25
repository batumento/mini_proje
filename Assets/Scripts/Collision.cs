using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collect")
        {
            if (!ATMRush.instance.moneys.Contains(other.gameObject))
            {
                other.GetComponent<BoxCollider>().isTrigger = false;
                other.gameObject.tag = "Collected";
                other.gameObject.AddComponent<Collision>();
                other.gameObject.GetComponent<Rigidbody>().isKinematic = true;

                ATMRush.instance.StackMoney(other.gameObject, ATMRush.instance.moneys.Count - 1);
            }
        }
    }
}
