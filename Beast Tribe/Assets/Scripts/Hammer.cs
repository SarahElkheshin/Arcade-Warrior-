using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if (other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().TakeDamage(20);
        }
    }
}
