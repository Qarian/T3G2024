using System;
using UnityEngine;

[CreateAssetMenu(menuName = "T3G/Gameplay Data")]
[Serializable]
public class GameplayScriptable : ScriptableObject
{
    public int score;
    
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
