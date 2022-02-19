using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Animator _animator;
    public float Speed;
    private Vector3 _direction;
    public float rotationSpeed = 10;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift))
            Speed = 6;
        else
            Speed = 4;


        Vector3 directionVector = new Vector3(_direction.x, 0, _direction.z);

        _animator.SetFloat("speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);

        if (directionVector.magnitude > Mathf.Abs(0.07f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationSpeed);

    }

    void FixedUpdate()
    {
        transform.position = transform.position + _direction * Time.fixedDeltaTime * Speed;
    }
}