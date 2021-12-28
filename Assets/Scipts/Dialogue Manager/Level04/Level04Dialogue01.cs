using UnityEngine;

public class Level04Dialogue01 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            FindObjectOfType<AudioManager>().Play("are the darklings");
            this.gameObject.SetActive(false);
            Invoke("line02", 4.5f);
        }
    }
    void line02(){
        FindObjectOfType<AudioManager>().Play("what if they kill");
        Invoke("line03", 2f);
    }
    void line03(){
        FindObjectOfType<AudioManager>().Play("but then again i have lost");
    }
}
