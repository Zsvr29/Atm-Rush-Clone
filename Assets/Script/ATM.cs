using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ATM : MonoBehaviour
{

    public TextMeshProUGUI text;
    int sayac = 0;

    private void OnTriggerEnter(Collider other)
    {
     

        if (other.gameObject.tag=="Picked")
        {
            Destroy(other.gameObject);
            FindObjectOfType<LerpMechanic>().cubes.Remove(other.gameObject);
            sayac++;
            text.text=sayac.ToString();
            Debug.Log(sayac);
            

           
        }
       
    }

    

}
