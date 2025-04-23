using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
