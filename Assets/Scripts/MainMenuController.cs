using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
  public GameObject menuPanel;
  public GameObject tutorialPanel;

  public Button startButton;
  public Button exitButton;
  public Button returnButton;
  public Button tutorialButton;

  void Start()
  {
    EnableMenuPanel();

    startButton.onClick.AddListener(StartGame);
    exitButton.onClick.AddListener(ExitGame);
    returnButton.onClick.AddListener(EnableMenuPanel);
    tutorialButton.onClick.AddListener(EnableTutorialPanel);
  }

  public void StartGame()
  {
    SceneManager.LoadScene(1);
  }

  public void ExitGame()
  {
    // works in build, not in unity editor play test
    Debug.Log("Exit only works in build.");
    Application.Quit();
  }

  public void EnableTutorialPanel()
  {
    menuPanel.SetActive(false);
    tutorialPanel.SetActive(true);
  }

  public void EnableMenuPanel()
  {
    tutorialPanel.SetActive(false);
    menuPanel.SetActive(true);
  }
}
