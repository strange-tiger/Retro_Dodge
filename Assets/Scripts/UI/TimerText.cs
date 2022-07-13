using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    public float SurvivalTime { get; private set; }
    public bool isOn { get; set; }

    private TextMeshProUGUI _ui;
    private float _elapsedTime = 0f;

    void Start()
    {
        _ui = GetComponent<TextMeshProUGUI>();
        _ui.text = $"시간 : {(int)SurvivalTime}초";
        isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn)
        {
            _elapsedTime += Time.deltaTime;
            if (_elapsedTime > 1f)
            {
                SurvivalTime += _elapsedTime;
                _elapsedTime = 0f;
                _ui.text = $"시간 : {(int)SurvivalTime}초";
            }
        }
    }
}
