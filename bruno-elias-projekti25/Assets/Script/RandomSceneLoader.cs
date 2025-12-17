using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class RandomSceneLoader : MonoBehaviour
{
    public string[] scenes = { "Minigame1", "Minigame2", "Minigame3" };
    public TextMeshProUGUI MinigameText;
    public TextMeshProUGUI player1OverallScoreText;
    public TextMeshProUGUI player2OverallScoreText;

    void Start()
    {
        player1OverallScoreText.text = "" + Globals.player1OverallScore;
        player2OverallScoreText.text = "" + Globals.player2OverallScore;
        StartCoroutine(LoadRandomScene());
    }

    public IEnumerator LoadRandomScene()
    {
        int randomIndex = Random.Range(0, scenes.Length);

        MinigameText.text = scenes[randomIndex];

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene(scenes[randomIndex]);
    }
}
