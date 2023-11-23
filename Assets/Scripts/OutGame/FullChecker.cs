using UnityEngine;
using UnityEngine.UI;

public class FullChecker : MonoBehaviour
{
    public Image topLeft;
    public Image topRight;
    public Image bottomLeft;
    public Image bottomRight;
    public Sprite notCompleted;
    public Button buttonFull;
    public Button buttonCamera;
    public Button buttonInfo;

    void Start()
    {
        if(topLeft.sprite != notCompleted && topRight.sprite != notCompleted && bottomLeft.sprite != notCompleted && bottomRight.sprite != notCompleted)
        {
            buttonFull.interactable = true;
            buttonCamera.interactable = true;
            buttonInfo.interactable = true;
        }
        else
        {
            buttonFull.interactable = false;
            buttonCamera.interactable = false;
            buttonInfo.interactable = false;
        }
    }
}
