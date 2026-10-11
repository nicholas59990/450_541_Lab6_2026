using UnityEngine;


// Sends the player's movement to the Animator every frame
// so the right animation plays at the right time.
public class PlayerAnimatorController : MonoBehaviour
{
    private Animator animator;       // plays the animations
    private PlayerMovement movement; // our movement script (for IsGrounded)
    private Rigidbody rb;            // used to read how fast the player moves


    private void Start()
    {
        // Find the components on this same GameObject
        animator = GetComponent<Animator>();
        movement = GetComponent<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        // Send the current speed to the blend tree
        animator.SetFloat("CharacterSpeed", rb.linearVelocity.magnitude);


        // Tell the Animator if we're on the ground (controls Falling)
        bool grounded = movement.IsGrounded;
        animator.SetBool("IsGrounded", grounded);

        // When Fire1 (left mouse button / left Ctrl) is released, roll
        if (Input.GetButtonUp("Fire1"))
        {
            animator.SetTrigger("doRoll");
        }

        if (grounded) {
            // Throw away a double jump request that was never used
            animator.ResetTrigger("doDoubleJump");
        }
        else {
            // Double jump. Space again in mid-air
            // The flip only plays if PlayerMovement really jumped
            if (Input.GetButtonDown("Jump") && movement.TryDoubleJump()) {
                animator.SetTrigger("doDoubleJump");
            }
        }
    }
}
