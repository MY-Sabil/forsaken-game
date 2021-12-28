using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheckParticles : MonoBehaviour
{
    [SerializeField] private GameObject JumpParticle;

    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "ground"){
            Instantiate(JumpParticle, transform.position, JumpParticle.transform.rotation);   
        }
        
    }
}
