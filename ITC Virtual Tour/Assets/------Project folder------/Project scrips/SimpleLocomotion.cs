using UnityEngine;
using Unity.XR.CoreUtils;

public class SimpleLocomotion : MonoBehaviour
{
    [Header("References")]
    public XROrigin xrOrigin;
    public float moveSpeed = 1.5f;
    public bool Move = false; // Set this to true when "Point" gesture is detected

    private CharacterController characterController;
    private Transform cameraTransform;

    void Start()
    {
        if (xrOrigin == null)
            xrOrigin = FindObjectOfType<XROrigin>();

        characterController = xrOrigin.GetComponent<CharacterController>();
        cameraTransform = xrOrigin.Camera.transform;

        UpdateCharacterControllerHeight();
    }

    void Update()
    {
        if (Move)
        {
            Vector3 direction = cameraTransform.forward;
            direction.y = 0; // Keep movement horizontal

            characterController.Move(direction.normalized * moveSpeed * Time.deltaTime);

            UpdateCharacterControllerHeight();
        }
    }
    public void Boolenabled(bool enabled)
    {
        Move = enabled;
    }
    void UpdateCharacterControllerHeight()
    {
        if (xrOrigin == null || characterController == null)
            return;

        float headHeight = Mathf.Clamp(xrOrigin.CameraInOriginSpaceHeight, 1, 2);
        characterController.height = headHeight;

        Vector3 center = xrOrigin.CameraInOriginSpacePos;
        center.y = characterController.height / 2f;
        characterController.center = center;
    }
}
