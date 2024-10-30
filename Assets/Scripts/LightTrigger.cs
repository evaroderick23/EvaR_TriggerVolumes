using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{
    public GameObject sparkle;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("tRIIGER");
        sparkle.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
        sparkle.SetActive(true);
    }
}
