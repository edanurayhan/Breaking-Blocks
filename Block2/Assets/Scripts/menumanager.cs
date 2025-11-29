using UnityEngine;
using UnityEngine.SceneManagement;

public class menumanager : MonoBehaviour
{ public void girisbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void cýkýsbutton()
    {
        Application.Quit();
    }

    
}
