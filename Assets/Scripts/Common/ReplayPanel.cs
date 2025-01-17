using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public static class ReplayPanel 
{
    public static void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit(0);
#endif
    }

    public static void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
