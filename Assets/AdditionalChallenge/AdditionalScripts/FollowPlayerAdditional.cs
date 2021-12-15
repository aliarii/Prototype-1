using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerAdditional : MonoBehaviour
{
    public GameObject player;
    public GameObject playerTwo;
    public GameObject cameraMain;
    public GameObject cameraSecond;
    private Vector3 offsetPo = new Vector3(0, 5, -7);
    private Vector3 offsetPt = new Vector3(0, 5, -7);
    private Vector3 previousOffsetPo;
    private Vector3 previousOffsetPt;

    private void Start()
    {
        previousOffsetPo = offsetPo;
        previousOffsetPt = offsetPt;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (previousOffsetPo != offsetPo)
            {
                offsetPo = previousOffsetPo;
            }
            else
            {
                offsetPo = new Vector3(0, 2, 1);
            }

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (previousOffsetPt != offsetPt)
            {
                offsetPt = previousOffsetPt;
            }
            else
            {
                offsetPt = new Vector3(0, 2, 1);
            }

        }
        // Offset the camera behind the player by adding to the player's position
        cameraMain.transform.position = player.transform.position + offsetPo;
        cameraSecond.transform.position = playerTwo.transform.position + offsetPt;
    }
}
