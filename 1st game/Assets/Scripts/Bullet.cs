using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float dmg;
    private Vector3 _dir;

    void Update()
    {
        transform.Translate(_dir);
    }

    public void Init(Vector3 direction)
    {
        _dir = direction;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Destroy(gameObject);
    }
}
