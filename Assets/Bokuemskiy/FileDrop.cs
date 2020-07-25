using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
namespace Bokuemskiy{
    public class FileDrop : MonoBehaviour
    {
        public GameObject File;
        public string CoinTag = "Coin";
        public int CoinAmount = 5;
        private int CoinCollected = 0;
        bool Coin, Coin1, Coin2, Coin3, Coin4 = false;
        void GetCoin(){
            CoinCollected++;
            if (CoinCollected == CoinAmount){
                AllCoinsCollected();
            }
        }
        void LostCoin() {
            CoinCollected--;
        }
        void OnTriggerEnter(Collider other){
            if (other.CompareTag(CoinTag)){
            GetCoin();
            }
            // if (other.gameObject.CompareTag("Coin")){
            //     Coin = true;
            // }
            // if (other.gameObject.CompareTag("Coin1")){
            //     Coin1 = true;
            // }
            // if (other.gameObject.CompareTag("Coin2")){
            //     Coin2 = true;
            // }
            // if (other.gameObject.CompareTag("Coin3")){
            //     Coin3 = true;
            // }
            // if (other.gameObject.CompareTag("Coin4")){
            //     Coin4 = true;
            // }
        }
        void OnTriggerExit(Collider other){
            if (other.CompareTag(CoinTag)){
            LostCoin();
            }
        }
        void AllCoinsCollected(){
                File.GetComponent<Rigidbody>().useGravity = true;
                File.GetComponent<VRTK_InteractableObject>().isGrabbable = true;
        }
    }
}