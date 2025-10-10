using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public TextMeshProUGUI pontuacaoTexto;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        AtualizarPontuacao();
    }

    // 🔹 STATIC para funcionar com GameManager.instance.AddScore()
    public void AddScore(int value)
    {
        score += value;
        AtualizarPontuacao();
    }

    void AtualizarPontuacao()
    {
        if (pontuacaoTexto != null)
        {
            pontuacaoTexto.text = "Pontuação: " + score.ToString();
        }
    }
}
