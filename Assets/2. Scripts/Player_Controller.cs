using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private Variables: 
    private AudioSource playerAS;

    [Header ("Attributes:")]
    public static int playerHealth = 100;

    [Header("Canvas References:")]
    public Text lifeSaverCounter;

    [Header("References:")]
    public AudioClip lifeSaverCollected;


    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
        playerAS = GetComponent<AudioSource>();
        lifeSaverCounter.GetComponent<Text>().text = " " + lifeSaverCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        lifeSaverCounter.GetComponent<Text>().text = " " + lifeSaverCounter.ToString();
    }

    #endregion

    #region Main Methods: 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            playerAS.PlayOneShot(lifeSaverCollected);
            Lifesaver.lifeSaverCount += 1;
            lifeSaverCounter.GetComponent<Text>().text = " " + lifeSaverCounter.ToString();
        }
    }

    #endregion
}
