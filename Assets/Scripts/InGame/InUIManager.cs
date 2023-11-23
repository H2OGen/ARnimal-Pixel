using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InUIManager : MonoBehaviour
{
    public GameObject winMenu;
    public GameObject loseMenu;
    public GameObject menu;
    public Image[] gameLife;
    public Image[] winLife;
    public GameManager gameManager;
    public Sprite noLife;

    private void Update()
    {
        if (gameManager.life < 5)
        {
            gameLife[4].sprite = noLife;
            if (gameManager.life < 4)
            {
                gameLife[3].sprite = noLife;
                if (gameManager.life < 3)
                {
                    gameLife[2].sprite = noLife;
                    if (gameManager.life < 2)
                    {
                        gameLife[1].sprite = noLife;
                        if (gameManager.life < 1)
                        {
                            gameLife[0].sprite = noLife;
                        }
                    }
                }
            }
        }
    }
    public void Win()
    {
        winMenu.SetActive(true);
        if (gameManager.life < 5)
        {
            winLife[4].sprite = noLife;
            if (gameManager.life < 4)
            {
                winLife[3].sprite = noLife;
                if (gameManager.life < 3)
                {
                    winLife[2].sprite = noLife;
                    if (gameManager.life < 2)
                    {
                        winLife[1].sprite = noLife;
                    }
                }
            }
        }
    }
    
    public void Lose()
    {
        loseMenu.SetActive(true);
    }
    public void ShowMenu()
    {
        menu.SetActive(true);
    }
    public void HideMenu()
    {
        menu.SetActive(false);
    }
    public void MoveScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void Restart()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sceneIndex);
    }
}
