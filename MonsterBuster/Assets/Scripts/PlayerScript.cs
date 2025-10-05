using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    public TextMeshProUGUI vida;
    public int vidaCount = 5;
    

    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        vidaCount--;

      

        if (vida) vida.text = vidaCount.ToString();

        if (vidaCount == 0)
        {
            SceneManager.LoadSceneAsync(4);
        }
        
    }
}
