using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class RandomSceneLoader : MonoBehaviour
{
    // Listaa scenet, joista haluat satunnaisen
    public string[] scenes = { "Minigame1", "Minigame2", "Minigame3" };
    public TextMeshProUGUI MinigameText;
    void Start()
    {
        LoadRandomScene();
    }
    public void LoadRandomScene()
    {
        // Valitaan satunnainen indeksi
        int randomIndex = Random.Range(0, scenes.Length);

        // Ladataan satunnainen scene
        // SceneManager.LoadScene(scenes[randomIndex]);
        MinigameText.text = scenes[randomIndex];
    }
}
