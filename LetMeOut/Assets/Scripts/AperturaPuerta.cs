using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AperturaPuerta : MonoBehaviour
{
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            anim.Play("Puerta 0");
        }
    }
}
