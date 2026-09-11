using UnityEngine;
using UnityEngine.SceneManagement;

public class anaMenuManager : MonoBehaviour
{
    public void OyunaBasla()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void OyundanCik() 
    { 
        Application.Quit();
    }
}
