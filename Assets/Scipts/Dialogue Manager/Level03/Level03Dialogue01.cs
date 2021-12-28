using UnityEngine;

public class Level03Dialogue01 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            FindObjectOfType<AudioManager>().Play("but then again how are we");
            this.gameObject.SetActive(false);
            Invoke("line02", 3.5f);
        }
    }
    void line02(){
        FindObjectOfType<AudioManager>().Play("even though we");
        Invoke("line03", 4f);
    }
    void line03(){
        FindObjectOfType<AudioManager>().Play("on the inside");
        Invoke("line04", 3f);
    }
    void line04(){
        FindObjectOfType<AudioManager>().Play("we were just puppets");
    }
}
