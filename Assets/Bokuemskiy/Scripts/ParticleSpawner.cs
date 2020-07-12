    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class ParticleSpawner : MonoBehaviour
    {
    public ParticleSystem Particle;

    public int hp = 10;    
    // void OnTriggerEnter (Collider other){
    // hp--;
    // ParticleSystem ParticleSpawned = Instantiate(Particle, this.transform);        
    // ParticleSpawned.Play();
    // }
    void OnCollisionEnter (Collision other){
    hp--;
    Debug.Log("touched");
    ParticleSystem ParticleSpawned = Instantiate(Particle, other.contacts[0].point, Quaternion.identity);        
    ParticleSpawned.Play();
    }
    void Update(){
    if (hp<=0){
    Destroy(this.gameObject);
    }
    }
    }