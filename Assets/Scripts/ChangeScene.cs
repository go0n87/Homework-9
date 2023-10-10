using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    private Scene _currentScene;

    int _indexCurrentScene;

    private void Start()
    {
        _indexCurrentScene =    _getCurrentBuildIndex();
    }

    public void Superman()
    {
        _indexCurrentScene  =   _getCurrentBuildIndex();
        SceneManager.LoadScene(0);
        SceneManager.UnloadSceneAsync(_indexCurrentScene);
     
    }

    public void Billiard()
    {
        _indexCurrentScene = _getCurrentBuildIndex();
        SceneManager.LoadScene(1);
        SceneManager.UnloadSceneAsync(_indexCurrentScene);
      
    }

    public void SphereOfAntigravity()
    {
        _indexCurrentScene = _getCurrentBuildIndex();
        SceneManager.LoadScene(2);
        SceneManager.UnloadSceneAsync(_indexCurrentScene);

    }

    private int _getCurrentBuildIndex()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
}
