using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int SceneNum;

    public void LoadScene()
    {
        SpawnLevel._level = 0;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneNum);
    }

}
