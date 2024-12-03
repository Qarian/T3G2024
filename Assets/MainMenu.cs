using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject player;
    
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;

    private void Start()
    {
        startButton.onClick.AddListener(StartNewGame);
        exitButton.onClick.AddListener(ExitGame);
        
        player.gameObject.SetActive(false);
    }

    private void ExitGame()
    {
        Application.Quit();
    }

    private void StartNewGame()
    {
        mainMenu.gameObject.SetActive(false);
        player.gameObject.SetActive(true);
    }
}
