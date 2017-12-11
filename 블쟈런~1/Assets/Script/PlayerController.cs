using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    public float moveSpeed;
    public float speedMultipier;

    public float speedIncreaseMilestone;
    private float speedMilestoneCount;

    public float jumpForce;

    public float jumpTime;
    private float jumpTimeCounter;

    private Rigidbody2D MyRigidbody;

    public bool grounded;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    public float groundCheckRadius;

    private Animator myAnimator;

    public GameManager theGameManager;
    public bool IsDead;

    //private Collider2D myCollider;

    [HideInInspector]
    public Vector3 Start_Point;

	private bool IsFirst;
    // Use this for initialization
    void Start() {
		IsFirst = true;
        MyRigidbody = GetComponent<Rigidbody2D>();

       // myCollider = GetComponent<Collider2D>();

        myAnimator = GetComponent<Animator>();
        Start_Point = gameObject.transform.position;

        jumpTimeCounter = jumpTime;

        speedMilestoneCount = speedIncreaseMilestone;
    }

    // Update is called once per frame
    void Update() {
        //grounded = Physics2D.IsTouchingLayers(myCollider, whatIsGround);
		if (IsFirst)
		{
			while (grounded) 
			{
				MyRigidbody.position = new Vector2 (MyRigidbody.position.x, MyRigidbody.position.y-0.1f);
			}
			IsFirst = false;
		}

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        if (transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;

            speedIncreaseMilestone = speedIncreaseMilestone * speedMultipier;
            moveSpeed = moveSpeed * speedMultipier;
        }

        MyRigidbody.velocity = new Vector2(moveSpeed, MyRigidbody.velocity.y);//앞으로 이동

        Jump();

        myAnimator.SetFloat("Speed", MyRigidbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);

    }

    //점프 함수
    public void Jump()
    {
        if (grounded && Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            MyRigidbody.velocity = new Vector2(MyRigidbody.velocity.x, jumpForce);
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0))
        {
            if (jumpTimeCounter > 0)
            {
                MyRigidbody.velocity = new Vector2(MyRigidbody.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space) || Input.GetMouseButtonUp(0))
        {
            jumpTimeCounter = 0;
        }

        if (grounded)
        {
            jumpTimeCounter = jumpTime;
        }
    }

    //시작 지점 리턴
    public Vector3 GetStartPoint()
    {
        Vector3 startpoint = new Vector3(Start_Point.x, Start_Point.y+4, Start_Point.z);
        return startpoint;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "killbox")
        {
            theGameManager.RestartGame();
            IsDead = true;
        }
    }
}
