using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // 1. 게임이 종료되면 GameOverUI를 보여줘야 함.
    // 2. 재시작 안내를 해준다
    public TimerText Timer;
    public GameObject GameOver;
    public GameOverUI GameOverUI;

    private bool _isOver;

    private void Update()
    {
        // 만약에 게임이 종료가 되었다면
        // R키를 눌러 재시작
        if (_isOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void End()
    {
        // 타이머 종료
        Timer.isOn = false;

        // 데이터 저장
        int savedBestTime = PlayerPrefs.GetInt("BestTime", 0);
        int bestTime = Mathf.Max((int)Timer.SurvivalTime, savedBestTime);
        
        PlayerPrefs.SetInt("BestTime", bestTime);

        // GameOverUI에 갱신
        GameOverUI.Activate(bestTime);

        // _isOver = true;
        _isOver = true;
    }
}
