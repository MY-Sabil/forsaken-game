using UnityEngine;
using UnityEngine.SceneManagement;

public class ItAllStartedWithCurse : MonoBehaviour
{
    void Start()
    {
        
        FindObjectOfType<AudioManager>().Play("it all started");
        Invoke("ChangeScene", 3.5f);
    }

    void ChangeScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
