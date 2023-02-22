using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impacto : MonoBehaviour
{
    private Animator anim;
    private GameObject Bacteria;
    private BoxCollider boxCollider;

    void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider>();
        Bacteria = GameObject.FindWithTag("Bacteria");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            anim.Play("ZombieDeath");
            boxCollider.enabled = false;
        }
    }
}