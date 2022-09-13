using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Button exitButton;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = Time.timeScale == 1 ? Time.timeScale = 0 : Time.timeScale = 1;
            exitButton.gameObject.SetActive(!exitButton.gameObject.activeInHierarchy);
        }
    }

    public void ExitButtonPressed()
    {
        SceneManager.LoadScene(0);
    }
}
