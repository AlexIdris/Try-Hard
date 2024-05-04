using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject healthBar;
    public GameObject key;
    public GameObject player;
    public PlayableDirector nextScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        { 
            healthBar.SetActive(false);
            key.SetActive(false);
            player.SetActive(false);
            nextScene.Play();

            
        }
    }

}

