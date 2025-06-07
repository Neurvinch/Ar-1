using UnityEngine;


public class locationcntrl : MonoBehaviour
{
    public GameObject planetObject;
    public Vector3 RotationVector;

    private void Update()
    {
        planetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
   
}
