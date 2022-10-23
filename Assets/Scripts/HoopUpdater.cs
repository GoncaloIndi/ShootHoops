using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopUpdater : MonoBehaviour
{
    [SerializeField] private Animator anim;
    private static readonly int Property = Animator.StringToHash("2");
    private static readonly int Property1 = Animator.StringToHash("1");
    private static readonly int Property2 = Animator.StringToHash("3");

    public void UpdateHoopAnimation(int score)
    {
        if (score == 6)
        {
            anim.SetTrigger(Property1);
        }
        else if (score == 12)
        {
            anim.SetTrigger(Property);
        }
        else if (score == 18)
        {
            anim.SetTrigger(Property2);
        }
        
    }
}
