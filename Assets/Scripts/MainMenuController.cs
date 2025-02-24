using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
  public Button startButton;
  public Button exitButton;

  void Start()
  {
      startButton.onClick.AddListener(StartGame);
      exitButton.onClick.AddListener(ExitGame);
  }

  public void StartGame()
  {
    SceneManager.LoadScene(1);
  }

  public void ExitGame()
  {
    Application.Quit();
  }
}
