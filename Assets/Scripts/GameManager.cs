using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver { get; set; } = false;
    public GameObject scoreText; 
    public GameObject endingScoreText;
    public GameObject restartMenu;
    public UnityEvent onGameOver;
    public void GameOver()
    {
        isGameOver = true;
        scoreText.SetActive(false);
        endingScoreText.GetComponent<TMPro.TMP_Text>().text = scoreText.GetComponent<TMPro.TMP_Text>().text;
        restartMenu.SetActive(true);
        onGameOver?.Invoke();
    }
    public void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
