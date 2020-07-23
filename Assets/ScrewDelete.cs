using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewDelete : MonoBehaviour
{
    int Screws = 0;
    void OnCollisionEnter (Collision other) {
        if (other.gameObject.CompareTag("Screw")) {
            Destroy(other.gameObject);
            Screws++;
        }
    }
    void Update () {
        if (Screws == 4) {
            Debug.Log("Toilet.delete");
        }
    }
}
