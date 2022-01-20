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

    [Header("Health References")]
    public GameObject life75;
    public GameObject life50;
    public GameObject life25;

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        #region GetComponents: 
        sharkEnemyGO.GetComponent<GameObject>();
        escapeText.GetComponent<GameObject>();
        tipText.GetComponent<GameObject>();
        life75.GetComponent<GameObject>();
        life50.GetComponent<GameObject>();
        life25.GetComponent<GameObject>();
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
        switch (Player_Controller.health)
        {
            case 75:
                life75.SetActive(true);
                break;
            case 50:
                life75.SetActive(false);
                life50.SetActive(true);
                break;
            case 25:
                life50.SetActive(false);
                life25.SetActive(true);
                break;
            case 0:
                SceneManager.LoadScene("InterludeMenu");
                LifeSaver_Behaviour.lifeSaverCount = 0;
                sharkEnemyGO.SetActive(false);
                break;
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
