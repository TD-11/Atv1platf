using UnityEngine;

[CreateAssetMenu(fileName = "SaveDataSO", menuName = "Scriptable Objects/SaveDataSO")]
public class SaveDataSO : ScriptableObject
{
    public Color circleColor;

    public string SaveDataToJson()
    {
        return JsonUtility.ToJson(this);
    }

    public void loadFromJson(string json)
    {
        JsonUtility.FromJsonOverwrite(json, this);
    }
}
