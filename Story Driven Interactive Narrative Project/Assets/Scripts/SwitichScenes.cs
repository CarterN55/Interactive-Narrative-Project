using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitichScenes : MonoBehaviour
{
    public string sceneName;

    public void ChangeScenes()
    {
        SceneManager.LoadScene(sceneName);
    }
}
