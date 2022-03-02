using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToClone : MonoBehaviour
{
    [SerializeField] private GameObject objectToClone;
    [SerializeField] public Transform[] points;
    void Awake()
    {
        var index = Random.Range(0, points.Length);
        var newGo = Instantiate(objectToClone, points[index].position, Quaternion.identity);
    }

}
