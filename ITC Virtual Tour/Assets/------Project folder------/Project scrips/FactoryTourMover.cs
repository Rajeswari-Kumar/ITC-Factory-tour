using System.Collections;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.UI;

public class BirdEyeViewSimple : MonoBehaviour
{
    public Toggle toggle;
    public Camera camera;
    public XROrigin xrOrigin;

    


    private void Start()
    {
        if (toggle != null)
            toggle.onValueChanged.AddListener(OnToggleChanged);
    }

    private void OnDestroy()
    {
        if (toggle != null)
            toggle.onValueChanged.RemoveListener(OnToggleChanged);
    }

    private void OnToggleChanged(bool isOn)
    {
        if (isOn)
        {
            StartCoroutine(BirdEyeViewFunc());
        }
        else
        {
         
        }
    }

    IEnumerator BirdEyeViewFunc()
    {
        camera.gameObject.SetActive(true);
        xrOrigin.Camera = camera;
        yield return new WaitForSeconds(7f);
        camera.gameObject.SetActive(false);
        xrOrigin.Camera = Camera.main;
    }

}
