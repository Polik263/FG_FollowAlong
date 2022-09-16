using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float speed;
    private bool isActive;

    void Update()
    {
        if (isActive)
        {
            transform.Translate(transform.forward * speed);
        }
    }
}
