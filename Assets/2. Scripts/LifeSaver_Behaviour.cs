using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSaver_Behaviour : MonoBehaviour
{
    #region Variables to use: 

    [Header("Attributes")]
    public static int lifeSaverCount = 10;

    [Header("References: ")]
    public Transform lifeSaver;
    

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        lifeSaver.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }

    #endregion

    #region Main Methods: 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.gameObject.SetActive(false);
        }
    }
    private void Rotate()
    {
        lifeSaver.transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
    }

    #endregion
}
