using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialog02 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            FindObjectOfType<AudioManager>().Play("beings of light");
            this.gameObject.SetActive(false);
            Invoke("Line02", 2f);
        }
    }

    void Line02(){
        FindObjectOfType<AudioManager>().Play("the name sounds");
        Invoke("Line03", 2f);
    }
    void Line03(){
        FindObjectOfType<AudioManager>().Play("but unlike the gods");
        Invoke("Line04", 6f);
    }
    void Line04(){
        FindObjectOfType<AudioManager>().Play("am i even allowed");
    }

}
