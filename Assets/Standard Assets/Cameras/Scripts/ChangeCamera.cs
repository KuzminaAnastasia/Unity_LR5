using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

	public GameObject CCTVCamera;
    public GameObject MainCamera;
    public bool whichcam = false;

    private void Update()
    {
        if (Input.GetKeyUp("c"))
        {
            if (whichcam == false)
            {
                whichcam = true;
            }
            else if (whichcam == true)
            {
                whichcam = false;
            }
        }

        if (whichcam == false)
        {
            CCTVCamera.active = true;
            MainCamera.active = false;
        }

        if (whichcam == true)
        {
            CCTVCamera.active = false;
            MainCamera.active = true;
        }
    }
}
