using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerControler : MonoBehaviour
{
    float jumpForce = 420f;
    float walkForce = 9f;
    float maxWalkSpeed = 2f;
    Animator anim;

    public Sprite[] walkSprites;
    public float animationPeriod = 0.1f;
    float time = 0;
    int idx = 0;
    int key = 0;
    SpriteRenderer sr;

    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        key = 0;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            key = 10;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            key = -10;
        }
        //if (key != 0) {
        //    transform.localScale = new Vector3();
        // }
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * jumpForce);
        }

        if (rb.linearVelocityX < maxWalkSpeed)
        {
            rb.AddForce(transform.right * walkForce * key);
        }
        time += Time.deltaTime;

        
        if (time > animationPeriod)
        {
            time = 0;
            sr.sprite = walkSprites[idx];
            idx++;
            if (idx == walkSprites.Length)
            {
                idx = 0;
            }
        }

        anim.speed = Mathf.Abs(rb.linearVelocityX);

        if (transform.position.y < -8)
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
        }
    }




    private void OnTriggerEnter2D(Collider other)
    {
        SceneManager.LoadScene("ClearScene");
        Debug.Log("성공");
    }
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("ClearScene");
        Debug.Log("성공");
    }
}
