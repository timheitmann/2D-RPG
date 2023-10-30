using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private GameInput gameInput;
    [SerializeField] private ContactFilter2D movementFilter;

    private bool isRunning;
    private float horizontal;
    private float vertical;
    private float lastHorizontal;
    private float lastVertical;
    private bool isWalking;
    private List<RaycastHit2D> hits = new List<RaycastHit2D>();
    private Rigidbody2D rb;
    
    private float collisionOffset = 0.1f;
    

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Awake() {
        lastVertical = -1f;
    }

    private void FixedUpdate() {
        HandleMovement();
    }

    private void HandleMovement() {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        bool inputSprint = gameInput.IsRunning();

        bool success = MovePlayer(inputVector);

        if(!success) {
            success = MovePlayer(new Vector2(inputVector.x, 0f));

            if(!success) {
                MovePlayer(new Vector2(0f, inputVector.y));
            }
        }


        horizontal = inputVector.x;
        vertical = inputVector.y;

        if(inputVector != Vector2.zero) {
            lastHorizontal = inputVector.x;
            lastVertical = inputVector.y;
            if (inputSprint) {
                isRunning = true;
                moveSpeed = 8f;
            } else {
                isRunning = false;
                moveSpeed = 5f;
            }
            isWalking = true;
        } else {
            isWalking = false;
            isRunning = false;
        }
    }

    private bool MovePlayer(Vector2 direction) {
        float moveDistance = moveSpeed * Time.fixedDeltaTime;

        int count = rb.Cast(direction, movementFilter, hits, moveDistance + collisionOffset);

        if(count == 0) {
            Vector2 moveVector = direction * moveDistance;

            rb.MovePosition(rb.position + moveVector);
            return true;
        } else {
            return false;
        }

    }

    public bool IsRunning() {
        return isRunning;
    }

    public float GetHorizontal() {
        return horizontal;
    }

    public float GetVertical() {
        return vertical;
    }

    public float GetLastHorizontal() {
        return lastHorizontal;
    }

    public float GetLastVertical() {
        return lastVertical;
    }

    public bool IsWalking() {
        return isWalking;
    }
}
