using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealsSpawn : MonoBehaviour
{
    [SerializeField] private GameObject objectToClone;
    [SerializeField] public Transform[] points;
    
    void Awake()
    {
        var index = 0;
        while (index <= 2)
        {
            index++;
            var newGo = Instantiate(objectToClone, points[index].position, Quaternion.identity);
            Debug.Log(index);
        }
        
    }

}
