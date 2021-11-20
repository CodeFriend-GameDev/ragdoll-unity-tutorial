using UnityEngine;
using UnityEngine.SceneManagement;

// Permet de recharger la sc�ne actuelle
public class ReloadScene : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
