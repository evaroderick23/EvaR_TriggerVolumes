using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialTrigger : MonoBehaviour
{
    public GameObject animation;
    private Animator tree;
    // Start is called before the first frame update
    void Start()
    {
        tree = animation.GetComponent<Animator>();
        tree.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        tree.enabled = true;
    }
    void OnTriggerExit(Collider other)
    {
        tree.enabled = false;
    }
}
