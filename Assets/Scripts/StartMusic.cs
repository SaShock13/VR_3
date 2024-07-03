using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    [SerializeField] AudioSource partyMusic;
    [SerializeField] AudioSource backMusic;
    Animator[] animations;

    private void Awake()
    {                
        animations = FindObjectsByType<Animator>(FindObjectsSortMode.None);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            StartTheParty();
        }
    }

    void StartTheParty()
    {
        backMusic.Stop();
        partyMusic.Play();
        foreach (var anim in animations)
        {
            anim.SetTrigger("Dance");
        }
    }
}
