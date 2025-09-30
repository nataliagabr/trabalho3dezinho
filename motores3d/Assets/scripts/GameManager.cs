using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // referência única (singleton)

    public int score = 0;
    public TextMeshProUGUI pontuacaoTexto;

    private void Awake()
    {
        // Garante que só existe um GameManager
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Pontuação: " + score);
        pontuacaoTexto.text = "Pontuação: " + score;
    }
}