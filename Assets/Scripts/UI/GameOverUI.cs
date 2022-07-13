using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public TextMeshProUGUI BestTimeUI;

    public void Activate(int bestTime)
    {
        gameObject.SetActive(true);
        BestTimeUI.text = $"�ְ� ��� : {bestTime}��";
    }
}
