using System;
using UnityEngine;

public class EnemyVision : MonoBehaviour
{
    public Action<Vector3> PlayerInVision;
    public Action PlayerLost;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            PlayerInVision?.Invoke(other.transform.position);
    }

    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            PlayerLost?.Invoke();
    }
}
