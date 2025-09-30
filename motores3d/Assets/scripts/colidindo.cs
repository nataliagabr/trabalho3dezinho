using UnityEngine;

public class colidindo : MonoBehaviour
{
    public int valor = 1; 
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.AddScore(valor); 
            Destroy(gameObject);        
        }
    }
}

