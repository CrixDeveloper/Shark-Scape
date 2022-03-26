using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShark_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private Variables: 
    protected AudioSource sharkAS;

    [Header("References & Attributes: ")]
    public NavMeshAgent sharkAgent;
    public Transform playerTarget;
    public AudioClip playerHurt;

    public int count;
    public float duracionDeLaSpeed;
    public bool incrementar;
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
        //SpeedUpSharkAgent();

        SubirVelocidad();
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

    private void SubirVelocidad()
    {
        if (LifeSaver_Behaviour.lifeSaverCount == 4)
        {
            incrementar = true;

            if (incrementar)
            {
                duracionDeLaSpeed -= Time.deltaTime;

                if (count == 0)
                {
                    sharkAgent.speed = sharkAgent.speed + 5;
                    count = 1;
                }
                if (duracionDeLaSpeed <= 0)
                {
                    sharkAgent.speed = 15f;
                    duracionDeLaSpeed = 5f;
                    count = 0;
                    incrementar = false;
                }
            }
        }
        else if (LifeSaver_Behaviour.lifeSaverCount > 4)
        {
            sharkAgent.speed = 15f;
            duracionDeLaSpeed = 5f;
            count = 0;
            incrementar = false;
        }


        if (LifeSaver_Behaviour.lifeSaverCount == 6)
        {
            incrementar = true;

            if (incrementar)
            {
                duracionDeLaSpeed -= Time.deltaTime;

                if (count == 0)
                {
                    sharkAgent.speed = sharkAgent.speed + 6;
                    count = 1;
                }
                if (duracionDeLaSpeed <= 0)
                {
                    sharkAgent.speed = 15f;
                    duracionDeLaSpeed = 5f;
                    count = 0;
                    incrementar = false;
                }
            }
        }
        else if (LifeSaver_Behaviour.lifeSaverCount > 6)
        {
            sharkAgent.speed = 15f;
            duracionDeLaSpeed = 5f;
            count = 0;
            incrementar = false;
        }


        if (LifeSaver_Behaviour.lifeSaverCount == 8)
        {
            incrementar = true;

            if (incrementar)
            {
                duracionDeLaSpeed -= Time.deltaTime;

                if (count == 0)
                {
                    sharkAgent.speed = sharkAgent.speed + 7;
                    count = 1;
                }
                if (duracionDeLaSpeed <= 0)
                {
                    sharkAgent.speed = 15f;
                    duracionDeLaSpeed = 5f;
                    count = 0;
                    incrementar = false;
                }
            }
        }
        else if (LifeSaver_Behaviour.lifeSaverCount > 8)
        {
            sharkAgent.speed = 15f;
            duracionDeLaSpeed = 5f;
            count = 0;
            incrementar = false;
        }


        if (LifeSaver_Behaviour.lifeSaverCount == 10)
        {
            incrementar = true;

            if (incrementar)
            {
                duracionDeLaSpeed -= Time.deltaTime;

                if (count == 0)
                {
                    sharkAgent.speed = sharkAgent.speed + 8;
                    count = 1;
                }
                if (duracionDeLaSpeed <= 0)
                {
                    sharkAgent.speed = 15f;
                    duracionDeLaSpeed = 5f;
                    count = 0;
                    incrementar = false;
                }
            }
        }
        else if (LifeSaver_Behaviour.lifeSaverCount > 10)
        {
            sharkAgent.speed = 15f;
            duracionDeLaSpeed = 5f;
            count = 0;
            incrementar = false;
        }


        if (LifeSaver_Behaviour.lifeSaverCount == 12)
        {
            incrementar = true;

            if (incrementar)
            {
                duracionDeLaSpeed -= Time.deltaTime;

                if (count == 0)
                {
                    sharkAgent.speed = sharkAgent.speed + 9;
                    count = 1;
                }
                if (duracionDeLaSpeed <= 0)
                {
                    sharkAgent.speed = 15f;
                    duracionDeLaSpeed = 5f;
                    count = 0;
                    incrementar = false;
                }
            }
        }
        else if (LifeSaver_Behaviour.lifeSaverCount > 12)
        {
            sharkAgent.speed = 15f;
            duracionDeLaSpeed = 5f;
            count = 0;
            incrementar = false;
        }
    }



    //private void SpeedUpSharkAgent()
    //{
    //    switch (LifeSaver_Behaviour.lifeSaverCount)
    //    {
    //        case 4:
    //            sharkAgent.speed = sharkAgentSpeed * speedMultiplier;
    //            StartCoroutine(SlowDownShark());
    //            break;
    //        case 8:
    //            sharkAgent.speed = sharkAgentSpeed * speedMultiplier;
    //            StartCoroutine(SlowDownShark());
    //            break;
    //        case 12:
    //            sharkAgent.speed = sharkAgentSpeed * speedMultiplier;
    //            StartCoroutine(SlowDownShark());
    //            break;

    //    }
    //}

    //private IEnumerator SlowDownShark()
    //{
    //    yield return new WaitForSeconds(5f);
    //    sharkAgent.speed = sharkAgentSpeed;
    //}
    #endregion
}
