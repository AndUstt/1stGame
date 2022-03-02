using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] GameObject heals;
    public int hp = 100;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DamageObject"))
            hp -= 25;

        if (other.CompareTag("Heal"))
        {
            hp += 25;
            Destroy(heals);
        }
        Debug.Log(hp);
    }
    void Update()
    {
        if (hp <= 0)
            Destroy(gameObject);

    }
}
