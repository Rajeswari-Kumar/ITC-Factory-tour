using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnimationTriggerControllerScript : MonoBehaviour
{
    public Animator Animator;
    public Toggle Item;
    public string AnimName;
    public AudioClip AudioClip;
    private void Start()
    {
        Item.onValueChanged.AddListener(OnItemValueChanged);
    }

    private void OnDestroy()
    {
        Item.onValueChanged.RemoveListener(OnItemValueChanged);
    }

    private void OnItemValueChanged(bool isOn)
    {
        if (isOn)
        {
            Animator.SetTrigger("Idle");
            StartCoroutine(PlayAnim(AnimName));
        }
    }

   
    private IEnumerator PlayAnim(string triggerName)
    {
        yield return new WaitForSeconds(1.5f);
        Animator.SetTrigger(triggerName);
        Debug.Log($"Triggered animation: {triggerName}");
    }
}
