using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeatCameraFollower : MonoBehaviour
{

    public GameObject vehicle;
    [SerializeField] Vector3 offset = new Vector3(-0.4f, 2, 0.6f); 
    

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = vehicle.transform.position + offset;
    }
}
