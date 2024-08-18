using UnityEngine;

public class Dinosaurio : MonoBehaviour
{
    [SerializeField] private float upForce;

    private Rigidbody2D dinoRb;

    void Start()
    {
        dinoRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dinoRb.AddForce(Vector2.up * upForce);
        }
    }
}
