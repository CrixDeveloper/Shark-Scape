using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    #region Variables to use: 

    [Header ("References:")]
    public GameObject sharkEnemyGO;
    public GameObject escapeText;
    public GameObject tipText;

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        #region GetComponents: 
        sharkEnemyGO.GetComponent<GameObject>();
        escapeText.GetComponent<GameObject>();
        tipText.GetComponent<GameObject>();
        #endregion 
    }

    // Update is called once per frame
    void Update()
    {
        CheckLifeSaverAmmount();
        CheckPlayerHealth();
    }

    #endregion

    #region Main Methods: 

    private void CheckPlayerHealth()
    {
        if (Player_Controller.health == 0)
        {
            SceneManager.LoadScene("InterludeMenu");
        }
    }

    private void CheckLifeSaverAmmount()
    {
        switch (LifeSaver_Behaviour.lifeSaverCount)
        {
            case 1:
                sharkEnemyGO.SetActive(true);
                break;
            case 5:
                tipText.SetActive(true);
                Destroy(tipText, 10f);
                break;
            case 10:
                escapeText.SetActive(true);
                Destroy(escapeText, 10f);
                break;
        }
    }

    #endregion
}
