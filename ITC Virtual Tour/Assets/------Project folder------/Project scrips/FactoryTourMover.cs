using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryTourMover : MonoBehaviour
{
    public Transform Point1;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveTo(Transform point)
    {
        transform.position = point.position;
    }

    //public void AnimNameChange(string name)
    //{
    //    var animControllers = FindObjectsOfType<AnimationTriggerControllerScript>();
    //    foreach (var controller in animControllers)
    //    {
    //        controller.animName = name;
    //        Debug.Log(controller.animName);
    //    }
    //}

}
