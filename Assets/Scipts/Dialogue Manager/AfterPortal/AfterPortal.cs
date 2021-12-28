using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterPortal : MonoBehaviour
{

    public GameObject butItAll;

    void Start()
    {
        Invoke("line01", 1f);
    }

    void line01(){
        FindObjectOfType<AudioManager>().Play("but when I walked");
        Invoke("line02", 2.5f);
    }
    void line02(){
        FindObjectOfType<AudioManager>().Play("they were not afraid");
        Invoke("line03", 2.5f);
    }
    void line03(){
        FindObjectOfType<AudioManager>().Play("they did not hate me");
        Invoke("line04", 2f);
    }
    void line04(){
        FindObjectOfType<AudioManager>().Play("they were just curious");
        Invoke("line05", 2.5f);
    }
    void line05(){
        FindObjectOfType<AudioManager>().Play("and after i explained");
        Invoke("line06", 5.5f);
    }
    void line06(){
        FindObjectOfType<AudioManager>().Play("later i also realized");
        Invoke("line07", 5f);
    }
    void line07(){
        FindObjectOfType<AudioManager>().Play("they had their own reasons");
        Invoke("line08", 3f);
    }
    void line08(){
        FindObjectOfType<AudioManager>().Play("and now after all this");
        Invoke("line09", 5f);
    }
    void line09(){
        FindObjectOfType<AudioManager>().Play("bad was good");
        Invoke("line10", 3.5f);
    }
    void line10(){
        butItAll.SetActive(true);
        FindObjectOfType<AudioManager>().Play("but it all started");
        Invoke("creditScene", 4.5f);
    }

    void creditScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }    
}
