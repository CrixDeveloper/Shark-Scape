using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSaver_Behaviour : MonoBehaviour
{
    #region Variables to use: 

    [Header("References: ")]
    public GameObject lifeSaver;

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            lifeSaver.gameObject.SetActive(false);
        }
    }

    #endregion
}
