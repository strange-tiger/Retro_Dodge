using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 1. ������ ����Ǹ� GameOverUI�� ������� ��.
    // 2. ����� �ȳ��� ���ش�
    public TimerText Timer;
    public GameObject GameOver;
    public GameOverUI GameOverUI;

    private bool _isOver;

    private void Update()
    {
        // ���࿡ ������ ���ᰡ �Ǿ��ٸ�
        // RŰ�� ���� �����
        if (_isOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void End()
    {
        // Ÿ�̸� ����
        Timer.isOn = false;

        // ������ ����
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Mathf.Max((int)Timer.SurvivalTime, savedBestTime);
        
        PlayerPrefs.SetInt("BestTime", bestTime);

        // GameOverUI�� ����
        GameOverUI.Activate(bestTime);

        // _isOver = true;
        _isOver = true;
    }
}
