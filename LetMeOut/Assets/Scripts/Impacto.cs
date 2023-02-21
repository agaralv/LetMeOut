using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impacto : MonoBehaviour
{
    private bool Impacticado = false;
    GameObject Bacteria;

    void Start()
    {
        Bacteria = GameObject.FindWithTag("Bacteria");
    }

    private void Update()
    {
        if (Impacticado == true)
        {
            Bacteria.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Impacticado = true;
        }
    }
}