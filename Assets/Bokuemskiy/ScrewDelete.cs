using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewDelete : MonoBehaviour
{
    public GameObject Toilet;
    int Screws = 0;
    void OnCollisionEnter (Collision other) {
        if (other.gameObject.CompareTag("Screw")) {
            Destroy(other.gameObject);
            Screws++;
             if (Screws == 4) {
            Toilet.transform.Translate(new Vector3(0.665f, 0, 0));
        }
        }
    }
}
