using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level02Dialogue01 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            FindObjectOfType<AudioManager>().Play("life was peaceful");
            this.gameObject.SetActive(false);
            Invoke("line02", 2.5f);
        }
    }

    void line02(){
        FindObjectOfType<AudioManager>().Play("we were happy");
        Invoke("line03", 2f);
    }
    void line03(){
        FindObjectOfType<AudioManager>().Play("what went wrong");
    }
}
