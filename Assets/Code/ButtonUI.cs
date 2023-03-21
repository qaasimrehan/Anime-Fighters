using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
[SerializeField] private string startGame = "Main Scene";
public void PlayGame()
{
    SceneManager.LoadScene(startGame);
}
}
