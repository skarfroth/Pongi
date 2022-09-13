using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject paddle1, paddle2;
    [SerializeField] private GameObject ball;

    private float originalBallSpeed;
    private Vector2 originalPaddle1Pos, originalPaddle2Pos;
    private Vector2 originalBallPos;

    private void Awake()
    {
        Time.timeScale = 1;
        GameObject settings = GameObject.Find("SettingsContainer");
        if (settings.GetComponent<MainMenu>().playVSLocal)
        {
            paddle2.GetComponent<PlayerController>().shouldUse2PControls = true;
        }
    }

    private void Start()
    {
        originalPaddle1Pos = paddle1.transform.position;
        originalPaddle2Pos = paddle2.transform.position;
        originalBallPos = ball.transform.position;
        originalBallSpeed = ball.GetComponent<Ball>().movementSpeed;
    }

    public void ResetBoard()
    {
        paddle1.transform.position = originalPaddle1Pos;
        paddle2.transform.position = originalPaddle2Pos;
        ball.transform.position = originalBallPos;
        ball.GetComponent<Ball>().movementSpeed = originalBallSpeed;
    }
}
