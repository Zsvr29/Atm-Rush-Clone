using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FinishMoneyObjects : MonoBehaviour
{
    public List<GameObject> moneyList = new List<GameObject>();

    private void Update()
    {
        foreach (var item in FindObjectOfType<FinishMoneyObjects>().moneyList)
        {

            if (item.transform.position.y + 1.5f < transform.position.y)
            {

                item.SetActive(true);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            transform.DOMoveY(FindObjectOfType<LerpMechanic>().sayac+1, 5f);
            FindObjectOfType<Movement>().moveSpeed = 0;
           FindObjectOfType<Movement>().swipeSpeed = 0;
            transform.DOMoveX(0f, 1f);

        }
    }
}
