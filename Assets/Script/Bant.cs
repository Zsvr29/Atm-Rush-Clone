using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Bant : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Picked")
        {
            other.transform.parent = null;
            other.transform.DOMoveX(-4f, 1f);


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag=="Picked")
        {
            Destroy(other.gameObject);
            FindObjectOfType<LerpMechanic>().cubes.Remove(other.gameObject);
        }
    }
}
