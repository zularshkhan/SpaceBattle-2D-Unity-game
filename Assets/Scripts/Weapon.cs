using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public GameObject Bullet;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(Bullet, firepoint.position, firepoint.rotation);
        }
    }
}
