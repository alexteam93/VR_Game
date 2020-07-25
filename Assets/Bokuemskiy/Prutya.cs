using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
public class Prutya : MonoBehaviour
{
    public GameObject ScrewDriver;
    int hp = 10;
    void OnTriggerEnter (Collider other) {
        if (other.gameObject.CompareTag("File")){
            hp--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0){
            Destroy(this.gameObject);
            ScrewDriver.GetComponent<VRTK_InteractableObject>().isGrabbable = true;
        }
    }
}
