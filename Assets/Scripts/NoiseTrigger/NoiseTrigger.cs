using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class NoiseTrigger : MonoBehaviour
{
    public float alertLevel = 5f;
    public UnityEngine.Events.UnityEvent alertEvent;
    void OnCollisionEnter(Collision col)
    {
        float noiseLevel = col.relativeVelocity.magnitude;

        if(noiseLevel > alertLevel)
        {
            alertEvent?.Invoke();
        }

    }
}
