using UnityEngine;

public class Level02Dialogue02 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            FindObjectOfType<AudioManager>().Play("life as a being");
            this.gameObject.SetActive(false);
            Invoke("line02", 4f);
        }
    }

    void line02(){
        FindObjectOfType<AudioManager>().Play("everyone was kind");
        Invoke("line03", 3.5f);
    }
    void line03(){
        FindObjectOfType<AudioManager>().Play("it all changed");
    }
}
