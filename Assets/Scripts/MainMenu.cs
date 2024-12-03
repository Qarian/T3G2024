using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button exitButton;

    private void Start()
    {
        exitButton.onClick.AddListener(ExitGame);
    }

    public void Init(GameManager manager)
    {
        startButton.onClick.AddListener(manager.StartGame);
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
