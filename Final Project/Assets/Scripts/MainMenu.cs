using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   public int startingScene;

   public void OnPlayButtonPressed()
   {
    SceneManager.LoadScene(startingScene);
   }

   public void OnQuitButtonPressed()
   {
    Application.Quit();
   }
}
