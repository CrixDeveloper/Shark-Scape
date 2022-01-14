using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private Variables: 
    private AudioSource closeSharkAS;

    [Header("References: ")]
    public GameObject sharkPrefab;
    public Transform playerPrefab;
    public NavMeshAgent sharkAgent;
    public AudioClip closeToPlayer;

    [Header("Attributes: ")]
    public float sharkAgentSpeed = 3.5f;
    public float damage = 20f;

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        closeSharkAS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    #endregion

    #region Main Methods: 

    private void FollowPlayer()
    {
        closeSharkAS.PlayOneShot(closeToPlayer);
        sharkAgent.SetDestination(playerPrefab.transform.position);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Bit");
        }
    }

    #endregion
}
