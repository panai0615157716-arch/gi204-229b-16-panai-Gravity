using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Gravity : MonoBehaviour
{
    Rigidbody rb;
    const float G = 0.006674f;

    public static List<Gravity> otherObjectsLiat;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (otherObjectsLiat == null)
        { 
            otherObjectsLiat = new List<Gravity>();
        }

        otherObjectsLiat.Add(this);

    }

    private void FixedUpdate()
    {
        foreach (Gravity obj in otherObjectsLiat)
        {
            if (obj != this)
            {
                Attract(obj);
            }
        }
    }

    void Attract(Gravity other)
    {
        Rigidbody otherRb = other.rb;

        Vector3 direction = rb.position - otherRb.position;

        float distance = direction.magnitude;

    }
}
