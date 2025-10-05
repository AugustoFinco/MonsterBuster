using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TouchScript : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int scoreCount = 0;
    public bool fase1 = true;
    public bool fase2 = true;

    void Start()
    {
       
    }

    
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == UnityEngine.TouchPhase.Began)
            {
                Vector2 position = Camera.main.ScreenToWorldPoint(touch.position);

                Collider2D hit = Physics2D.OverlapPoint(position);

                if (hit != null)
                {
                    
                    scoreCount++;
                    if (score) score.text = scoreCount.ToString();
                    Destroy(hit.gameObject);
                }
                
            }

            
        }

        if (scoreCount == 15 && fase1)
        {
            SceneManager.LoadSceneAsync(2);
        }
        if (scoreCount == 15 && fase2)
        {
            SceneManager.LoadSceneAsync(3);
        }
        if (scoreCount == 15 && fase1 == false && fase2 == false)
        {
            SceneManager.LoadSceneAsync(5);
        }
    }
}
