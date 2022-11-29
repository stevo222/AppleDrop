using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

[CreateAssetMenu(fileName = "DataStorage", menuName = "Utilities/Data Storage Object")]

public class DataStorage : ScriptableObject
{
    public ScriptableObject data;

    public List<ScriptableObject> ListData;

    private void GetOnRaise()
    {
        GetData(data);
    }

    private void SetOnRaise()
    {
        SetData(data);
    }

    private void SetListData()
    {
        foreach (var obj in ListData)
            SetData(obj);
    }

    public void GetListData()
    {
        foreach (var obj in ListData)
        {
            GetData(obj);
        }
    }

    public void SetData(ScriptableObject obj)
    {
        if (obj == null) return;
        PlayerPrefs.SetString(obj.name, JsonUtility.ToJson(obj));
    }

    public void SetData(MonoBehaviour obj)
    {
        if (obj == null) return;
        PlayerPrefs.SetString(obj.name, JsonUtility.ToJson(obj));
    }
    
    public void SetData()
    {
        if (data == null) return;
        PlayerPrefs.SetString(data.name, JsonUtility.ToJson(data));
    }
    
    public void GetData(ScriptableObject obj)
    {
        if (obj == null) return;
        if (!string.IsNullOrEmpty(PlayerPrefs.GetString(obj.name)))
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(obj.name), obj);
    }
    
    public void GetData(MonoBehaviour obj)
    {
        if (obj == null) return;
        if (!string.IsNullOrEmpty(PlayerPrefs.GetString(obj.name)))
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(obj.name), obj);
    }

    public void GetData()
    {
        if (data == null) return;
        if (!string.IsNullOrEmpty(PlayerPrefs.GetString(data.name)))
            JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(data.name), data);
    }
    
}
