using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    #region Variables to use: 

    [Header("References: ")]
    public GameObject lifeSaver;
    public Text lifeSaverText;

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        lifeSaver.GetComponent<GameObject>();
        lifeSaverText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Main Methods: 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Collectable")
        {
            lifeSaver.SetActive(false);
            IncreaseLifeSaver();
            lifeSaverText.text = " " + LifeSaver_Behaviour.lifeSaverCount.ToString();
        }
    }

    private void IncreaseLifeSaver()
    {
        LifeSaver_Behaviour.lifeSaverCount++;
    }

    #endregion
}
