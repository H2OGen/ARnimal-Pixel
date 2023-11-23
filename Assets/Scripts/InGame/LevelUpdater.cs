using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class LevelUpdater : MonoBehaviour
{
    private string jsonFilePath;

    private void Start()
    {
        jsonFilePath = Path.Combine(Application.persistentDataPath, "LevelCompletion.json");
    }

    public void UpdateLevelCompletion(int levelNumber, bool completed)
    {
        LevelData levelData;
        if (File.Exists(jsonFilePath))
        {
            string json = ReadJsonData();

            levelData = JsonUtility.FromJson<LevelData>(json);
        }
        else
        {
            levelData = new LevelData();
        }

        List<Level> levels = levelData.levels;
        Level levelToUpdate = levels.Find(level => level.levelNumber == levelNumber);
        if (levelToUpdate != null)
        {
            levelToUpdate.completed = completed;
            SaveJsonData(levelData);
        }
        else
        {
            Debug.LogError("Level " + levelNumber + " not found in LevelCompletion.json!");
        }
    }

    private string ReadJsonData()
    {
        if (File.Exists(jsonFilePath))
        {
            return File.ReadAllText(jsonFilePath);
        }
        else
        {
            Debug.LogWarning("LevelCompletion.json not found at " + jsonFilePath);
            return string.Empty;
        }
    }

    private void SaveJsonData(LevelData levelData)
    {
        string json = JsonUtility.ToJson(levelData);
        File.WriteAllText(jsonFilePath, json);
    }
}