using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gripperControl : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject l1, l2;
    public float offset = 0.01f;
    Vector3 defualt_l1_position, defualt_l2_position;
    void Start()
    {
        l1 = GameObject.Find("L1");
        l2 = GameObject.Find("L2");

        defualt_l1_position = new Vector3(0, 0.01f, 0);
        defualt_l2_position = new Vector3(0, -0.01f, 0);

        l1.transform.localPosition = defualt_l1_position;
        l2.transform.localPosition = defualt_l2_position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GlobalVariables_RWS_client.gripper_signal == 1)
        {
            l1.transform.localPosition = defualt_l1_position + new Vector3(0, -offset, 0);
            l2.transform.localPosition = defualt_l2_position + new Vector3(0, offset, 0);
        }
        else if(GlobalVariables_RWS_client.gripper_signal == 0)
        {
                l1.transform.localPosition = defualt_l1_position;
                l2.transform.localPosition = defualt_l2_position;
        }
        else
        {
            Debug.Log("Unknown signal!");
        }
    }
}
