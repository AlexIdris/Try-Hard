using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private GameObject key;
    [SerializeField] private GameObject keyframe;
    [SerializeField] private GameObject lockDoor;
    public float doorkey = 0;

    private void Start()
    {
        keyframe.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            key.SetActive(false);
            lockDoor.SetActive(false);
            keyframe.SetActive(true);
            doorkey++;


        }

    }
}
