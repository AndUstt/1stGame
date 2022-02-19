using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Animator _animator;
    public bool isGrounded;
    public short jump = 200;

    void Start()
    {
       _animator = GetComponent<Animator>();
    }
    void OnCollisionEnter()
    {
        isGrounded = true;
    }

    void Update()
    {
        OnJumping();
    }
    void OnJumping()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _animator.SetTrigger("IsJump");
            isGrounded = false;
            GetComponent<Rigidbody>().AddForce(new Vector3(0, jump, 0));
        }
    }
}
