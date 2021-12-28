using UnityEngine;

public class darkCheck : MonoBehaviour
{
    [SerializeField]
    private GameObject playerLight;

    void OnTriggerEnter2D(Collider2D other){
        playerLight.SetActive(true);
    }
}
