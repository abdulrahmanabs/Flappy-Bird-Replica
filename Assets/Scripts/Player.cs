using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float gravity = -9.8f;
    SpriteRenderer sr;
    public Sprite[] sprites;
    int currentSprite = 0;
    public float jumpSpeed;
    Vector3 direction;
    GameManager gameManager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
        gameManager = FindObjectOfType<GameManager>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up * jumpSpeed;
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    void AnimateSprite()
    {
        currentSprite++;
        if (currentSprite >= sprites.Length)
            currentSprite = 0;
        sr.sprite = sprites[currentSprite];

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch(collision.tag)
        {
            case "Obstacle":

                break;
            case "ScoreBorder":
                break;
                
        }
    }
}
