using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class TitleUIManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void MoveScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
    public void SwitchActive(GameObject gameObject)
    {
        if (gameObject != null)
        {
            bool isActive = gameObject.activeSelf;
            gameObject.SetActive(!isActive);
        }
    }
}
