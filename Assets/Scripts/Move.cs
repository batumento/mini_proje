using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float swipeSpeed;
    public float moveSpeed;

    private Camera camera;
    private void Start()
    {
        camera = Camera.main;
    }
    private void Update()
    {
        transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        if (Input.GetButton("Fire1"))
        {
            Movement();
        }
    }

    private void Movement()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = camera.transform.localPosition.z;
        
        Ray ray = camera.ScreenPointToRay(mousePos);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 200))
        {
            GameObject firstMoney = ATMRush.instance.moneys[0];
            Vector3 hitVec = hit.point;
            hitVec.y = firstMoney.transform.localPosition.y;
            hitVec.z = firstMoney.transform.localPosition.z;

            firstMoney.transform.localPosition = Vector3.MoveTowards(firstMoney.transform.localPosition,hitVec,Time.deltaTime * swipeSpeed);
        }
    }
}
