using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform gameObjectToRotate;

    // Update is called once per frame
    void Update()
    {
        gameObjectToRotate.transform.Rotate(new Vector3(0f, 30f, 0f) * Time.deltaTime);
    }
}
