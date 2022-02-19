using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayer : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    private Transform _playerPos;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
            _playerPos = other.transform;
        //Debug.Log(_playerPos);
    }

    private void Fire(Vector3 playerPos)
    {
        Debug.Log("Fire");
        var bulletGo = Instantiate(Bullet, transform.position, Quaternion.identity);
        bulletGo.GetComponent<Bullet>().Init(playerPos - transform.position);
    }

}
