using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private variables: 
    protected AudioSource playerAS;

    [Header("Attributes: ")]
    public static int health = 100;

    [Header("References: ")]
    public GameObject lifeSaver;
    public Text lifeSaverText;
    public AudioClip collectSound;

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        playerAS = GetComponent<AudioSource>();
        lifeSaver.GetComponent<Text>();

        health = 100;
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
            playerAS.PlayOneShot(collectSound);
            lifeSaver.SetActive(false);
            IncreaseLifeSaver();
            lifeSaverText.text = " " + LifeSaver_Behaviour.lifeSaverCount.ToString();
        }

        if (other.tag == "Key" && LifeSaver_Behaviour.lifeSaverCount >= 12)
        {
            Interlude.InterludeManager.CanFindKey();
            Interlude.InterludeManager.KeyFound();
        }
    }

    private void IncreaseLifeSaver()
    {
        LifeSaver_Behaviour.lifeSaverCount++;
    }

    #endregion
}
