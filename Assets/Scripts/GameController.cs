using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text _scoreText;  
    [SerializeField] private GameObject _gameOverGameObject;
    [SerializeField] private Button _retryButton;
    [SerializeField] private ZombieSpawn zombieSpawn;


    private int currentScore;

    void Awake()
    {
        _gameOverGameObject.SetActive(false);
        _retryButton.onClick.AddListener(RestartGame);
    }

    public void ScoreUp()
    {
        currentScore++;
        _scoreText.text = $"Score: {currentScore}";
    }

    public void GameOver()
    {
        zombieSpawn.GetComponent<ZombieSpawn>().StopCoroutine("Timer");
        _gameOverGameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
