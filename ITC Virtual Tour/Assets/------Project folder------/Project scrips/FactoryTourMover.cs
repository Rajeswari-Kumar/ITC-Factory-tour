using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class FactoryTourMover : MonoBehaviour
{
    public Transform Point1;
    
    public Camera Camera1;
    public XROrigin Player;
    public Transform BirdEyeViewEndPoint;
    public void MoveTo(Transform point)
    {
        transform.position = point.position;
    }

    //Bird eye view to 5 seconds
    public void BirdEyeView()
    {
        Player.Camera = Camera1;
        Camera1.transform.Translate(BirdEyeViewEndPoint.position,Space.World);
    }
 
}
