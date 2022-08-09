using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float velocity = 5f;
    private Vector2 currentVelocity;
    //private Animator playerAnimator;
    //private SpriteRenderer playerSpriteRenderer;
    private bool isFacingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        // playerAnimator = GetComponentInChildren<Animator>();
        // playerSpriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Move(){
        currentVelocity = new Vector2(Input.GetAxis("Horizontal") * velocity * Time.deltaTime, Input.GetAxis("Vertical") * velocity * Time.deltaTime);
        transform.Translate(currentVelocity);
        // playerAnimator.SetFloat("xVelocity", Mathf.Abs(currentVelocity.x));

        if(currentVelocity.x > 0f && !isFacingRight)
        {
            FlipPLayer();
        }
        else if(currentVelocity.x < 0f && isFacingRight)
        {
            FlipPLayer();
        }
    }
    private void FlipPLayer()
    {
        isFacingRight = !isFacingRight;
        // playerSpriteRenderer.flipX = !isFacingRight;
    }
}
