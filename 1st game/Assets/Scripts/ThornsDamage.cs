using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThornsDamage : MonoBehaviour
{
    [SerializeField] private GameObject Character;
    [SerializeField] private GameObject Enemy;
    
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
            Destroy(Character);

        if (other.CompareTag("Enemy"))
            Destroy(Enemy);
    }
}
