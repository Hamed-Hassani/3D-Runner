using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConroller : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;

    [SerializeField]
    float speed;

    [SerializeField]
    float jumpForce;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        rb.velocity = Vector3.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("jump");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

    }
}
