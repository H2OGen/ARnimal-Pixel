using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public Sprite whiteCellSprite;
    public Sprite blackCellSprite;
    public Sprite redCellSprite;
    public Sprite grayCellSprite;
    private Image buttonImage;
    public GameManager gameManager;

    private void Awake()
    {
        buttonImage = GetComponent<Image>();
    }

    public void TrueCell()
    {
        if (gameManager.block.isOn)
        {
            BlockOn();
        }
        else if (buttonImage.sprite == whiteCellSprite)
        {
            buttonImage.sprite = blackCellSprite;
            gameManager.points++;
        }
    }

    public void FalseCell()
    {
        if (gameManager.block.isOn)
        {
            BlockOn();
        }
        else if (buttonImage.sprite == whiteCellSprite)
        {
            buttonImage.sprite = redCellSprite;
            gameManager.life--;
        }
    }

    public void BlockOn()
    {
        if (buttonImage.sprite == whiteCellSprite)
        {
            buttonImage.sprite = grayCellSprite;
        }
        else if (buttonImage.sprite == grayCellSprite)
        {
            buttonImage.sprite = whiteCellSprite;
        }
    }
}