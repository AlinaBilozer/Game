using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    
    public void ChangeScenes(int numberScene)
    {
        SceneManager.LoadScene(numberScene);
    }
}
