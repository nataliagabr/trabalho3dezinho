using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int score = 0; // Pontuação global

    public static void AddScore(int value)
    {
        score += value;
        Debug.Log("Pontuação: " + score);
    }
}
