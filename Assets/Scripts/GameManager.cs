using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isGameOver { get; set; } = false;
    public GameObject scoreText; 
    public GameObject restartMenu;
    public void GameOver()
    {
        isGameOver = true;
        scoreText.SetActive(false);
        restartMenu.SetActive(true);
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
