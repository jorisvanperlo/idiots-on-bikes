using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject PreMenuPanel;
    public GameObject MainMenuPanel;
    public GameObject SettingsPanel;
    public GameObject CreditsPanel;
    public GameObject LevelSelectPanel;
    public GameObject MainBGPanel;

    void Start()
    {
        ShowPreMenu();
    }

    public void ShowLevelSelectMenu()
    {
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        SettingsPanel.SetActive(false);
        PreMenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(true);
        MainBGPanel.SetActive(true);
    }

    public void ShowCreditsMenu()
    {
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(true);
        SettingsPanel.SetActive(false);
        PreMenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        MainBGPanel.SetActive(true);
    }

    public void ShowPreMenu()
    {
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        SettingsPanel.SetActive(false);
        PreMenuPanel.SetActive(true);
        LevelSelectPanel.SetActive(false);
        MainBGPanel.SetActive(false);
    }

    public void ShowMainMenu()
    {
        MainMenuPanel.SetActive(true);
        CreditsPanel.SetActive(false);
        SettingsPanel.SetActive(false);
        PreMenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        MainBGPanel.SetActive(true);
    }

    public void ShowSettings()
    {
        MainMenuPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        SettingsPanel.SetActive(true);
        PreMenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(false);
        MainBGPanel.SetActive(true);
    }

    public void StartGame()
    {
        // Load your game scene here, e.g., using SceneManager
        // SceneManager.LoadScene("GameSceneName");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
