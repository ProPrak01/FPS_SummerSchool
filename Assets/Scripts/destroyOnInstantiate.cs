using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnInstantiate : MonoBehaviour
{
    public float time_delay;
   

    private void OnCollisionEnter(Collision other)
    {
        Invoke(nameof(DestroyThis),time_delay);
    }

    void DestroyThis()
    {
        Destroy(gameObject);
    }
}
