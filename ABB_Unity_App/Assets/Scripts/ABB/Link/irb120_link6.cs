﻿// ------------------------------------------------------------------------------------------------------------------------//
// ----------------------------------------------------- LIBRARIES --------------------------------------------------------//
// ------------------------------------------------------------------------------------------------------------------------//

// -------------------- Unity -------------------- //
using UnityEngine;

public class irb120_link6 : MonoBehaviour
{
    void FixedUpdate()
    {
        //transform.localEulerAngles = new Vector3((-1) * GlobalVariables_RWS_client.robotBaseRotLink_irb_joint[5], 0f, 0f);
        transform.localEulerAngles = new Vector3(GlobalVariables_RWS_client.robotBaseRotLink_irb_joint[5], 0f, 0f);
    }
    void OnApplicationQuit()
    {
        Destroy(this);
    }
}
