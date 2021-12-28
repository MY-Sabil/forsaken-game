using UnityEngine;

public class Level03Dialogue02 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            FindObjectOfType<AudioManager>().Play("how they treated me");
            this.gameObject.SetActive(false);
            Invoke("line02", 5.5f);
        }
    }
    void line02(){
        FindObjectOfType<AudioManager>().Play("i guess the yin yang");
    }
}
