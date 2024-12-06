using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RestartButton : MonoBehaviour
{
    private void Awake() => GetComponent<Button>().onClick.AddListener(Restart);
    private void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}