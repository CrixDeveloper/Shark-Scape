using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShark_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private Variables: 
    protected AudioSource sharkAS;
    private float speedMultiplier = 1.5f;

    [Header("References & Attributes: ")]
    public NavMeshAgent sharkAgent;
    public Transform playerTarget;
    public AudioClip playerHurt;

    public float sharkAgentSpeed = 15f;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player Hit");
            Player_Controller.health -= 25;
            sharkAS.PlayOneShot(playerHurt);
        }
    }

    private void FollowPlayer()
    {
        sharkAgent = GetComponent<NavMeshAgent>();
        sharkAgent.destination = playerTarget.transform.position;
    }

    private void SpeedUpSharkAgent()
    {
        switch (LifeSaver_Behaviour.lifeSaverCount)
        {
            case 4:
                sharkAgent.speed = sharkAgentSpeed * speedMultiplier;
                StartCoroutine(SlowDownShark());
                break;
            case 8:
                sharkAgent.speed = sharkAgentSpeed * speedMultiplier;
                StartCoroutine(SlowDownShark());
                break;
            case 12:
                sharkAgent.speed = sharkAgentSpeed * speedMultiplier;
                StartCoroutine(SlowDownShark());
                break;

        }
    }

    private IEnumerator SlowDownShark()
    {
        yield return new WaitForSeconds(5f);
        sharkAgent.speed = sharkAgentSpeed;
    }
    #endregion
}
