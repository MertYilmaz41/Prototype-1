using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject seatCamera;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Switch1"))
        {
            seatCamera.SetActive(false);
            mainCamera.SetActive(true);
        }

        if (Input.GetButtonDown("Switch2"))
        {
            seatCamera.SetActive(true);
            mainCamera.SetActive(false);
        }
      
    }
}
