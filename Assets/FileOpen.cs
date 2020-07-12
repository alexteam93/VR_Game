using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileOpen : MonoBehaviour
{
    public GameObject File;
    bool Coin, Coin1, Coin2, Coin3, Coin4 = false;
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Coin")){
            if (Coin==false) {
                Coin=true;
            }
        }
        if (other.gameObject.CompareTag("Coin1")){
            if (Coin1==false) {
                Coin1=true;
            }
        }
        if (other.gameObject.CompareTag("Coin2")){
            if (Coin2==false) {
                Coin2=true;
            }
        }
        if (other.gameObject.CompareTag("Coin3")){
            if (Coin3==false) {
                Coin3=true;
            }
        }
        if (other.gameObject.CompareTag("Coin4")){
            if (Coin4==false) {
                Coin4=true;
            }
        }
    }
    void Update(){
        if (Coin && Coin1 && Coin2 && Coin3 && Coin4){
        File.GetComponent<Rigidbody>().useGravity=true;
        }
    }
}
