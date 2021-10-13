using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Scene1 : MonoBehaviour
{
    public static Scene1 Instance;
    public TMP_InputField inputField;
    public TextMeshProUGUI bestPlayerScore;


    

    public string playerName;

    private string bestPlayer;
    private int bestScore;

    private void Start()
    {
        
    }
    private void Awake()
    {
        
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
            
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
            
        }


    }

    private void Update()
    {
        LoadBestScore();
        bestPlayerScore.text = "Best Score: " + bestPlayer + " : " + bestScore;
    }


    public void SetPlayerName()
    {
        playerName = inputField.text;
        SceneManager.LoadScene(1);
        gameObject.SetActive(false);
           
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    //[System.Serializable]
    //class SaveData
    //{
    //    public int bestScore;
    //}

    //public void SaveScore()
    //{
    //    SaveData data = new SaveData();
    //    data.bestScore = MainManager.;

    //    string json = JsonUtility.ToJson(data);

    //    File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    //}

    [System.Serializable]
    class SaveData
    {
        public int best_Points;
        public string best_Player;
    }
    public void LoadBestScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            bestScore = data.best_Points;
            bestPlayer = data.best_Player;

        }

    }


}
