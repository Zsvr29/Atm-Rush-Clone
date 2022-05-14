using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engel : MonoBehaviour
{
    ParticleSystem particle;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Picked")
        {
            Destroy(other.gameObject);
            
            FindObjectOfType<LerpMechanic>().cubes.Remove(other.gameObject);
             GameObject.Find("Coins").GetComponent<ParticleSystem>().Play();
            
           
           

        }

    }
    
  
}