using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class GameManager : MonoBehaviour
{
    public int life;
    public int maxPoints;
    public int points;
    public int currlvl;
    public Toggle block;
    public InUIManager inUIManager;
    public LevelUpdater levelUpdater;
    void Awake()
    {
        life = 5;
        points = 0;
        block.isOn = false;
    }
    private void Update()
    {
        if(maxPoints == points)
        {
            inUIManager.Win();
            levelUpdater.UpdateLevelCompletion(currlvl, true);
            Debug.Log("updated");
        }
        if(life <= 0)
        {
            inUIManager.Lose();
        }
    }
}
