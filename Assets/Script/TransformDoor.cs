using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformDoor : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Picked"||other.gameObject.tag=="First")
        {
           switch (other.gameObject.GetComponent<Door>().coinType)
            {
                case Door.CoinType.Dollar:
                    other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
                    other.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                    other.gameObject.GetComponent<Door>().coinType = Door.CoinType.Gold;
                    break;
                case Door.CoinType.Gold:
                    other.gameObject.transform.GetChild(1).gameObject.SetActive(false);
                    other.gameObject.transform.GetChild(2).gameObject.SetActive(true);
                    other.gameObject.GetComponent<Door>().coinType = Door.CoinType.Diamond;
                    break;

               

            }
        }
        
    }
}
