using System.Xml.Serialization;
using UnityEngine;

public class LocalData : MonoBehaviour
{
    private int score;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            score++;
            // 로컬 데이터 저장 ( Key , Value )
            PlayerPrefs.SetInt("Score", score);
            // 데이터 불러오기 
            PlayerPrefs.GetInt("Score");
        }
    }
}
