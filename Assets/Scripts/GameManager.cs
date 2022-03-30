using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    Animator ProffesourAnimator;
    [SerializeField]
    GameObject UI;
    [SerializeField]
    AudioClip AngryClip;
    [SerializeField]
    AudioClip TeachingClip;
    [SerializeField]
    TeleportPoint[] Points;


    AudioSource AS;
    private void Start()
    {
        AS = gameObject.GetComponent<AudioSource>();
    }

    public void EnterClass() {
        //AS.clip = AngryClip;
        //AS.Play();
        ProffesourAnimator.SetBool("Angry",true);
        UI.SetActive(true);
    }

    public void SorryButton() {
        ProffesourAnimator.SetBool("Angry", false);
        UI.SetActive(false);
       // UnlockTeleport(false);
        //AS.clip = TeachingClip;
        //AS.Play();
    }

    void UnlockTeleport(bool Active) {
        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].locked = Active;
        }
    }
}
