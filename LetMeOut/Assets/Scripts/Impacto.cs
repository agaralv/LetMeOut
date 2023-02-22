using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impacto : MonoBehaviour
{
    private Animator anim;
    private bool Impacticado = false;
    private GameObject Bacteria;
    private BoxCollider2D boxCollider2D;

    void Start()
    {
        anim = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        Bacteria = GameObject.FindWithTag("Bacteria");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            anim.Play("ZombieDeath");
            boxCollider2D.enabled = false;
        }
    }
}