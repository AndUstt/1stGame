using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    [SerializeField]
    private GameObject Door;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
            Destroy(Door);

    }
}
