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
            // ���� ������ ���� ( Key , Value )
            PlayerPrefs.SetInt("Score", score);
            // ������ �ҷ����� 
            PlayerPrefs.GetInt("Score");
        }
    }
}
