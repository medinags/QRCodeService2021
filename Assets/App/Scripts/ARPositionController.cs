﻿using MRTKExtensions.QRCodes;
using UnityEngine;

public class ARPositionController : MonoBehaviour
{
    [SerializeField]
    private QRTrackerController trackerController;
    [SerializeField] private AnchorModuleScript anchorModule;
    private void Start()
    {
        trackerController.PositionSet += PoseFound;
    }

    private void PoseFound(object sender, Pose pose)
    {
        var childObj = transform.GetChild(0);
        childObj.SetPositionAndRotation(pose.position, pose.rotation);
        childObj.gameObject.SetActive(true);
        //To create anchor in QR Code Position;
        //anchorModule.CreateAzureAnchor(childObj.gameObject);
    }
}