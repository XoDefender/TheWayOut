using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class SelectLevelUI : MonoBehaviour
{
    [SerializeField] private Button FirstLevelButton;
    [SerializeField] private Button SecondLevelButton;
    [SerializeField] private Button BackToMenuButton;

    void Awake()
    {
        FirstLevelButton.onClick.AddListener(FirstLevelButton_OnClick);
        SecondLevelButton.onClick.AddListener(SecondLevelButton_OnClick);
        BackToMenuButton.onClick.AddListener(BackToMenuButton_OnClick);
    }

    private void FirstLevelButton_OnClick()
    {
        SceneManager.LoadScene(2);
    }
    private void SecondLevelButton_OnClick()
    {
        SceneManager.LoadScene(3);
    }
    private void BackToMenuButton_OnClick()
    {
        SceneManager.LoadScene(0);
    }
}
