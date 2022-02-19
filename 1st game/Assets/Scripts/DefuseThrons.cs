using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefuseThrons : MonoBehaviour
{
    [SerializeField] private GameObject Throns;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Destroy(Throns);
            
    }
    
}


