using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShark_Controller : MonoBehaviour
{
    #region Variables to use: 

    [Header("References: ")]
    public NavMeshAgent sharkAgent;
    public Transform playerTarget;

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        sharkAgent.GetComponent<NavMeshAgent>();
        playerTarget.GetComponent<Transform>();
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
        sharkAgent.destination = playerTarget.transform.position;
    }

    #endregion
}
