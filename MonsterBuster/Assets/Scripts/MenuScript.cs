using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public int nextFase;

    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(nextFase);
    }

 
}
