using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {
    
    private const string IS_RUNNING = "IsRunning";
    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";
    private const string LAST_HORIZONTAL = "LastHorizontal";
    private const string LAST_VERTICAL = "LastVertical";
    private const string IS_WALKING = "IsWalking";

    [SerializeField] private Player player;

    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        animator.SetBool(IS_RUNNING, player.IsRunning());
        animator.SetFloat(HORIZONTAL, player.GetHorizontal());
        animator.SetFloat(VERTICAL, player.GetVertical());
        animator.SetFloat(LAST_HORIZONTAL, player.GetLastHorizontal());
        animator.SetFloat(LAST_VERTICAL, player.GetLastVertical());
        animator.SetBool(IS_WALKING, player.IsWalking());
    }

}
