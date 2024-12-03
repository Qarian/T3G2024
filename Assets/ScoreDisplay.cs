using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private GameplayScriptable gameplayData;
    
    private TMP_Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        textComponent.text = $"Score: {gameplayData.score}";
    }
}
