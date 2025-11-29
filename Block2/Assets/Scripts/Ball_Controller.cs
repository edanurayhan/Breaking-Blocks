using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    [Header("Components")]
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //rigidbodyi tutar

        rb.AddForce(Vector3.up * 300f); //topun hareketi hýzý

    }
}
