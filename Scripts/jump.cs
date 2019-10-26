using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jump : MonoBehaviour
{
    public Animator playerAnim;
    public Vector3 playerPosition;
    public Vector3 playerPositionRespawn;
    private float jumpTimeCounter;
    public float jumpTime;
    
    private Rigidbody2D rb;

    public float jumpForce;
    private int zmienna_jump;
    bool isGrounded;
    public Transform feetPos;
    public float checkRadius;
    bool isJumping;
    public LayerMask whatIsGround;

    private void Awake()
    {
        playerPositionRespawn = this.gameObject.transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {

        playerAnim.SetBool("jump", false);
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        if (isGrounded == true && (Input.GetKeyDown(KeyCode.Space) || zmienna_jump == 1))
        {
            playerAnim.SetBool("jump", true);
            isJumping = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
        }
        if((Input.GetKey(KeyCode.Space ) || zmienna_jump >= 1) && isJumping == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                zmienna_jump = 0;
                isJumping = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space) || zmienna_jump >= 2)
        {
            isJumping = false;
            zmienna_jump = 0;
        }
    }
    public void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.tag == "Enemy")
        {

            StartCoroutine(TimerCountDown());
        }
        if (obj.gameObject.tag == "baby2")
        {
            NextQuestionScript.lvl += 1;
        }
    }
    IEnumerator TimerCountDown()
    {
        float timestart = 2f;
        float step = 1;
        //float lastRealTime = 0.0f;
        //lastRealTime = Time.realtimeSinceStartup;
        while (timestart > 0)
        {
            playerAnim.SetBool("blink", true);
            timestart -= step;

            yield return new WaitForSeconds(step);
            //fishanimate["fishBlink"].time += (Time.realtimeSinceStartup - lastRealTime);
        }
        playerAnim.SetBool("blink", false);
    }
    public void Jumping()
    {
        zmienna_jump++;
    }
    public void JumpingDown()
    {
        zmienna_jump = 0;
    }
    
}
