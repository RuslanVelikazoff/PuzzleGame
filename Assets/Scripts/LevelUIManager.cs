using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUIManager : MonoBehaviour
{
    public Button closeLevelButton;

    private void Start()
    {
        ButtonFunc();
    }

    private void ButtonFunc()
    {
        if (closeLevelButton != null)
        {
            closeLevelButton.onClick.RemoveAllListeners();
            closeLevelButton.onClick.AddListener(() =>
            {
                SceneManager.LoadScene(0);
            });
        }
    }
}
