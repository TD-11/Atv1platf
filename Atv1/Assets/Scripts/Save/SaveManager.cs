using System;
using System.IO;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;
    public SaveData saveData;
    private string filePath;
    
    private void Awake()
    {
        if (!Instance)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        saveData = GetComponent<SaveData>();
        filePath = Application.persistentDataPath + "/SaveData.save";

    }

    public bool WriteSaveToFile()
    {
        try
        {
            string saveDataJson = saveData.saveDataSo.SaveDataToJson();
                File.WriteAllText(filePath, saveDataJson);
                Debug.Log("Save data written to file" + filePath);
                return true;
        }
        catch(Exception e)
        {
            Debug.LogError(e.Message);
            return false;
        }
    }

    public bool LoadSaveFromFile()
    {
        try
        {
            if (File.Exists(filePath))
            {
                string saveDataJson = File.ReadAllText(filePath);
                saveData.saveDataSo.loadFromJson(saveDataJson);
                Debug.Log("Save data loaded from file" + filePath);
                return true;
            }
            else
            {
                Debug.LogWarning("No save file found: " + filePath);
                return false;
            }
        }
        catch(Exception e)
        {
            Debug.LogError(e.Message);
            return false;
        }
    }
    
}
