using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class ATMRush : MonoBehaviour
{
    public static ATMRush instance;
    public List<GameObject> moneys = new List<GameObject>();
    public float movementDelay = 0.25f;
    public GameObject Player;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            MoveListElements();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            MoveOrigin();
        }
    }

    public void StackMoney(GameObject other, int index)
    {
        other.transform.parent = this.transform;
        Vector3 newPosition = moneys[index].transform.localPosition;
        newPosition.z += 1;
        other.transform.localPosition = newPosition;
        moneys.Add(other);
        StartCoroutine(MakeObjectsBigger());
    }

    private IEnumerator MakeObjectsBigger()
    {
        for (int i = moneys.Count - 1; i > 0; i--)
        {
            int index = i;
            Vector3 moneyScale = new Vector3(1, 1, 1);
            moneyScale *= 1.5f;
            moneys[index].transform.DOScale(moneyScale, 0.1f).OnComplete(() =>
             moneys[index].transform.DOScale(new Vector3(1, 1, 1), 0.1f));
            yield return new WaitForSeconds(0.05f);
        }
    }

    private void MoveListElements()
    {
        for (int i = 1; i < moneys.Count; i++)
        {
            Vector3 position = moneys[i].transform.localPosition;
            position.x = moneys[i - 1].transform.localPosition.x;
            moneys[i].transform.DOLocalMove(position, movementDelay);
        }
    }

    private void MoveOrigin()
    {
        for (int i = 1; i < moneys.Count; i++)
        {
            Vector3 position = moneys[i].transform.localPosition;
            position.x = moneys[0].transform.localPosition.x;
            moneys[i].transform.DOLocalMove(position, 0.70f);
        }
    }
}
