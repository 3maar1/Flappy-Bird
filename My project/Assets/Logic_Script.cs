using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic_Script : MonoBehaviour
{
    
    public int Score;
    public GameObject gos;
    public Text Score_Text;
    [ContextMenu("Increase Score")]
    public void Start()
    {
        gos = GameObject.FindGameObjectWithTag("gos");
        gos.SetActive(false);
    }
    public void ScoreCount(int ScoreToAdd)
    {
        Score += ScoreToAdd;
        Score_Text.text = Score.ToString();

    }
    public void GOS()
    {
        Time.timeScale = 0f;
        gos.SetActive(true);
    }


}
