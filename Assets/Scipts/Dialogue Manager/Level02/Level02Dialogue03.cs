using UnityEngine;

public class Level02Dialogue03 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            FindObjectOfType<AudioManager>().Play("darklings were brutal");
            this.gameObject.SetActive(false);
            Invoke("line02", 2f);
        }
    }

    void line02(){
        FindObjectOfType<AudioManager>().Play("they destroyed our home");
        Invoke("line03", 3.5f);
    }
    void line03(){
        FindObjectOfType<AudioManager>().Play("without any reason");
        Invoke("line04", 3f);
    }
    void line04(){
        FindObjectOfType<AudioManager>().Play("i still can't figure out");
    }
}
