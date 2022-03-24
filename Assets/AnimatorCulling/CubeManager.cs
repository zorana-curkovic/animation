using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public Animator Anim;
    void OnBecameVisible()
    {
        Debug.Log($"On became visible {name}");
    }

    void OnBecameInvisible()
    {
        Debug.Log($"On became INvisible {name}");

    }

    public void EnableGreen()
    {
        Anim.SetTrigger("Green");
    }
    
    public void EnableRed()
    {
        Anim.SetTrigger("Red");
    }

    public void DisableAll()
    {
        Anim.SetTrigger("Disable");
    }
    
    
}
