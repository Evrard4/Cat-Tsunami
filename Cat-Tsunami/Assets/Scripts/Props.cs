using UnityEngine;

public class Props : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
            Destroy(gameObject);
    }
}
