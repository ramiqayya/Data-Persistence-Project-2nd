using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scene2 : MonoBehaviour
{
    //public TextMeshProUGUI displayPlayer;



    //public void Awake()
    //{
    //    displayPlayer.text ="Best Score:Name: " +Scene1.Instance.playerName;
    //}

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
        Scene1.Instance.gameObject.SetActive(true);
    }

    
}
