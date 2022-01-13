using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_Manager : MonoBehaviour
{
    #region Variables to use: 



    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Main Methods: 

    public void PlayButton()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void ExitButton()
    {
        Debug.Log("The game will close... Thanks for playing.");
        Application.Quit();
    }

    #endregion 
}
