using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public int levelOne;
    public int levelTwo;

    public void OnLevelOnePressed()
    {
        SceneManager.LoadScene(levelOne);
    }

    public void OnLevelTwoPressed()
    {
        SceneManager.LoadScene(levelTwo);
    }
}
