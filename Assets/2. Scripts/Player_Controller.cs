using UnityEngine;
using UnityEngine.UI;

public class Player_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private Variables: 
    private AudioSource playerAS;

    [Header ("Attributes:")]
    public static int playerHealth = 100;

    [Header("References:")]
    public Text lifeSaverCountText;
    public AudioClip lsCollectedClip;
    public GameObject lifeSaver;
    
    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 100;
        playerAS = GetComponent<AudioSource>();
        lifeSaver = GetComponent<GameObject>();
        lifeSaverCountText.GetComponent<Text>().text = " " + lifeSaverCountText.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #endregion

    #region Main Methods: 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Debug.Log("LifeSaver Collected");
            playerAS.PlayOneShot(lsCollectedClip);
            FindObjectOfType<Lifesaver>().IncreaseLifeSaverNumber();
            lifeSaverCountText.text = Lifesaver.lifeSaverCount.ToString() + " ";
            lifeSaver.gameObject.SetActive(false);
        }
    }

    #endregion
}
