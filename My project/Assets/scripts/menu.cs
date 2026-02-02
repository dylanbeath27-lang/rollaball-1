using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour
{
public void onPlayButton ()
{
    SceneManager.LoadScene("rolla 1");
}

public void OnquitButton()
{
    Application.Quit();
}
}
