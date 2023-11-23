using UnityEngine;
using UnityEngine.SceneManagement;

public class OutUIManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
                MoveScene("TitleScene");
        }
    }

    public void SwitchActive(GameObject gameObject)
    {
        if (gameObject != null)
        {
            bool isActive = gameObject.activeSelf;
            gameObject.SetActive(!isActive);
        }
    }

    public void MoveScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}