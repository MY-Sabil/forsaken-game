using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenu;
    [HideInInspector] public bool isPaused;

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)){
            if(isPaused){
                ResumeGame();
            }
            else if(!isPaused){
                Pause();
            }
        }
    }

    public void Pause(){
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach(AudioSource a in audios){
            a.Pause();
        }
    }

    public void ResumeGame(){
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        UnPauseAudio();
    }

    public void ReturnToMenu(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        UnPauseAudio();
    }

    void UnPauseAudio(){
        AudioSource[] audios = FindObjectsOfType<AudioSource>();
        foreach(AudioSource a in audios){
            a.UnPause();
        }
    }
}
