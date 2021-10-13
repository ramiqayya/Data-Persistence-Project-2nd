using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class Scene1 : MonoBehaviour
{
    public static Scene1 Instance;
    public TMP_InputField inputField;

    public GameObject gameManager;

    public string playerName;
   


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
}
