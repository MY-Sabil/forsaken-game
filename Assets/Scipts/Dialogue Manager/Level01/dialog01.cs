using UnityEngine;

public class dialog01 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            FindObjectOfType<AudioManager>().Play("i was always taught");
            this.gameObject.SetActive(false);
            Invoke("playPart2", 4f);
        }
    }
    void playPart2(){
        FindObjectOfType<AudioManager>().Play("and here i am");
        Invoke("playPart3", 4f);
    }
    void playPart3(){
        FindObjectOfType<AudioManager>().Play("what an irony");
    }
}
