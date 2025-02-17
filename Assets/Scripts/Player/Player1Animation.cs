using UnityEngine;
using UnityEngine.Animations;

public class Player1Animation : MonoBehaviour
{
    public Animator animator;
    public void player2GotHeart()
    {
        animator.SetTrigger("OppGotHeart");
    }
}
