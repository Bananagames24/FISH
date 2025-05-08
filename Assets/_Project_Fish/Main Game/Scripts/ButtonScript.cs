using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("CreditsMenu");
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
