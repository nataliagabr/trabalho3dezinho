using UnityEngine;

public class colidindo : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Item coletado!");
            Destroy(gameObject); 
        }
    }
}
