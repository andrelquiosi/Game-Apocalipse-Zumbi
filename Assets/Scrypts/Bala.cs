using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
 public float velocidade = 20;
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>()
        .MovePosition(GetComponent<Rigidbody>().position + 
        transform.forward * velocidade * Time.deltaTime);
    }
}
