using UnityEngine;
using UnityEngine.SceneManagement;

public class ARGameManager : MonoBehaviour
{
    public void Speak(string Text)
    {
        Debug.Log(Text);
    }

    public void MoveScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}