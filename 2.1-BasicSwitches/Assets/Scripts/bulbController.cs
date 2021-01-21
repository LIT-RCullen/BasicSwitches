using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulbController : MonoBehaviour
{
    public Animator theAnimator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void bulbOn()
    {
        theAnimator.SetBool("bulbOn", true);
    }

    public void bulbOff()
    {
        theAnimator.SetBool("bulbOn", false);
    }
}
