using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(SpriteRenderer))]
public class Projectile : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D goRigidbody;
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private Vector2 direction;
    private float speed;

    private float lifeSpan = 10;

    private Sprite visualAsset;
    private Color colorAsset;

    private void Awake()
    {

        if (goRigidbody == null)
        {
            SetRigidbody2D(GetComponent<Rigidbody2D>());
        }

        if (spriteRenderer == null)
        {
            SetSpriteRenderer(GetComponent<SpriteRenderer>());
        }

        //SetLifeSpan(LifeSpan);
    }

    public void UpdateVisuals()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.sprite = visualAsset;
            spriteRenderer.color = colorAsset;
        }
    }

    public void SetAsset(Sprite visual, Color color)
    {
        visualAsset = visual;
        colorAsset = color;

        UpdateVisuals();
    }

    public void SetVelocity(Vector2 direction, float speed)
    {
        SetStartSpeed(speed);
        SetDirection(direction);

        if (goRigidbody != null)
        {
            goRigidbody.velocity = direction.normalized * speed;
        }
    }

    public void SetSpriteRenderer(SpriteRenderer spriteRenderer)
    {
        this.spriteRenderer = spriteRenderer;
    }

    public void SetRigidbody2D(Rigidbody2D rigidbody)
    {
        this.goRigidbody = rigidbody;

        this.goRigidbody.gravityScale = 0;

        rigidbody.velocity = direction.normalized * speed;
    }

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    public void SetStartSpeed(float speed)
    {
        this.speed = speed;
    }

    public void SetLifeSpan(float lifeSpan)
    {
        this.lifeSpan = lifeSpan;
        Destroy(this.gameObject, this.lifeSpan);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
