using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    [SerializeField] private Text player1ScoreText;
    [SerializeField] private Text player2ScoreText;
    [SerializeField] private GameController gameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            UpdateScore();
            gameController.ResetBoard();
        }
    }

    private void UpdateScore()
    {
        if (gameObject.CompareTag("Player1Goal"))
        {
            int.TryParse(player2ScoreText.text, out int score);
            player2ScoreText.text = (score + 1).ToString();
        }

        if (gameObject.CompareTag("Player2Goal"))
        {
            int.TryParse(player1ScoreText.text, out int score);
            player1ScoreText.text = (score + 1).ToString();
        }
    }
}
