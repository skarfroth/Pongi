using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public bool playWithYourself, playVSLocal;

    void Start()
    {
        DontDestroyOnLoad(this);
    }

    public void PlayWithYourSelf()
    {
        playWithYourself = true;
        SceneManager.LoadScene(1);
    }

    public void PlayVSLocal()
    {
        playVSLocal = true;
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
    
}
