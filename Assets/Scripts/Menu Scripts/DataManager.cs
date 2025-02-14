using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string playerName;
    public int highScore;

    public string recordOwner;
    public int recordScore;




    private void Awake()
    {

        LoadData();

        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    [SerializeField]
    class SavedData
    {
        public string playerName;
        public int highScore;
    }

    public void SaveData()
    {
        SavedData data = new SavedData();
        data.playerName = playerName;
        data.highScore = highScore;
        
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SavedData data = JsonUtility.FromJson<SavedData>(json);
            recordOwner = data.playerName;
            recordScore = data.highScore;
        }
    }



    }


