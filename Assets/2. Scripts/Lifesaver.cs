using UnityEngine;

public class Lifesaver : MonoBehaviour
{
    #region Variables to use: 

    // Static Variables: 
    public static int lifeSaverCount = 0;

    [Header("References: ")]
    public GameObject lifeSaver;
   
    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    private void Start()
    {
        lifeSaverCount = 0;
    }

    private void Update()
    {
        lifeSaver.transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
    }

    #endregion

    #region Main Methods: 

    public void IncreaseLifeSaverNumber()
    {
        lifeSaverCount++;
    }

    #endregion
}
