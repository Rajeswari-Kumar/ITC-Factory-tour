using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class AnimationTriggerControllerScript : MonoBehaviour
{
    public Animator Animator;
    //public Toggle Item;
    public string AnimName1;
    public string AnimName2;
    public AudioSource AudioClip;
    public bool NearSecurity = false;
    public bool IDValid = false;
    //private void Start()
    //{
    //    Item.onValueChanged.AddListener(OnItemValueChanged);
    //}

    //private void OnDestroy()
    //{
    //    Item.onValueChanged.RemoveListener(OnItemValueChanged);
    //}

    //private void OnItemValueChanged(bool isOn)
    //{
    //    if (isOn)
    //    {
    //        Animator.SetTrigger("Idle");
    //        StartCoroutine(PlayAnim(AnimName));
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Animator.SetTrigger("Idle");
            StartCoroutine(PlayAnim(AnimName1));
            NearSecurity = true;
        }
    }

    public void IDValidFunc(bool validity)
    {
        if(NearSecurity)
        {
            IDValid = validity;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(IDValid && other.CompareTag("Player"))
        {
            Animator.SetTrigger(AnimName2);
        }
    }
    private IEnumerator PlayAnim(string triggerName)
    {
        yield return new WaitForSeconds(1.5f);
        Animator.SetTrigger(triggerName);
        AudioClip.Play();
       // Debug.Log($"Triggered animation: {triggerName}");
    }
}
