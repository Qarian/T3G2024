using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private BallController player;
    [SerializeField] private MainMenu mainMenu;
    
    [SerializeField] private GameplayScriptable gameplayScriptable;

    private void Start()
    {
        player.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        mainMenu.Init(this);

        gameplayScriptable.score = 0;
    }

    public void StartGame()
    {
        player.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
    }
}
