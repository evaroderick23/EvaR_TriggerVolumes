using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearTrigger : MonoBehaviour
{
    public GameObject leave;

    private void OnTriggerEnter(Collider other)
    {
        
        leave.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        
        leave.SetActive(true);
    }
}
