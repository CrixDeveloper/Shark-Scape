using UnityEngine;
using UnityEngine.AI;

public class Enemy_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private Variables: 
    private AudioSource closeSharkAS;

    [Header("References: ")]
    public GameObject sharkPrefab;
    public Transform playerTarget;
    public NavMeshAgent sharkAgent;
    public AudioClip playerHurtClip;

    [Header("Attributes: ")]
    public float sharkAgentSpeed = 3.5f;
    public float damage = 20f;

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        closeSharkAS = GetComponent<AudioSource>();
        sharkAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    #endregion

    #region Main Methods: 

    public void FollowPlayer()
    {
        sharkAgent.destination = playerTarget.transform.position;
    }

    private void ActivateShark()
    {
        if (Lifesaver.lifeSaverCount == 1)
        {
            sharkPrefab.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Biten");
            closeSharkAS.PlayOneShot(playerHurtClip);
            Player_Controller.playerHealth -= 25;
        }
    }

    #endregion
}
