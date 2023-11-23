using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections.Generic;

[System.Serializable]
public class LevelData
{
    public List<Level> levels;
    public LevelData()
    {
        levels = new List<Level>();
        for (int i = 1; i <= 12; i++)
        {
            levels.Add(new Level(i, false));
        }
    }
}

[System.Serializable]
public class Level
{
    public int levelNumber;
    public bool completed;
    public Level(int number, bool completed)
    {
        levelNumber = number;
        this.completed = completed;
    }
}
public class LevelChecker : MonoBehaviour
{
    public List<Button> levelButtons;
    public List<Sprite> completionSprites;
    public Sprite notCompleted;

    private string jsonFilePath;

    private void Start()
    {
        jsonFilePath = Path.Combine(Application.persistentDataPath, "LevelCompletion.json");
        ReadJsonData();
    }

    private void ReadJsonData()
    {
        if (File.Exists(jsonFilePath))  
        {
            string json = File.ReadAllText(jsonFilePath);
            LevelData levelData = JsonUtility.FromJson<LevelData>(json);
            SetupLevel(levelData);
        }
        else
        {
            Debug.Log($"LevelCompletion.json not found at {jsonFilePath}. Generating new file...");
            LevelData levelData = new LevelData();
            SetupLevel(levelData);
        }
    }

    private void SetupLevel(LevelData levelData)
    {
        List<Level> levels = levelData.levels;

        for (int i = 0; i < levels.Count; i++)
        {
            Level level = levels[i];

            if (level.completed)
            {
                if (i < completionSprites.Count)
                {
                    levelButtons[i].image.sprite = completionSprites[i];
                }
                else
                {
                    Debug.LogError("Completion sprite for level " + (i + 1) + " is missing!");
                }
            }
            else
            {
                levelButtons[i].image.sprite = notCompleted;
            }
        }
    }
}