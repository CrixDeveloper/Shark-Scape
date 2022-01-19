using UnityEngine;
using UnityEngine.AI;

public class EnemyShark_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private Variables: 
    protected AudioSource sharkAS;

    [Header("References: ")]
    public NavMeshAgent sharkAgent;
    public Transform playerTarget;
    public AudioClip playerHurt;

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        sharkAgent.GetComponent<NavMeshAgent>();
        playerTarget.GetComponent<Transform>();
        sharkAS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    #endregion

    #region Main Methods: 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Hit");
            Player_Controller.health -= 100;
            sharkAS.PlayOneShot(playerHurt);
        }
    }

    private void FollowPlayer()
    {
        sharkAgent = GetComponent<NavMeshAgent>();
        sharkAgent.destination = playerTarget.transform.position;
        playerTarget = GetComponent<Transform>();
        sharkAgent.gameObject.transform.LookAt(playerTarget);
    }

    #endregion
}
