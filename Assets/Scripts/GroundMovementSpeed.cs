using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    [SerializeField] private float groundSpeed = 1.3f;
    [SerializeField] private float groundWidth = 6f;
    private SpriteRenderer _spriteRenderer;
    private Vector2 startSize;
    // Start is called before the first frame update
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + groundSpeed * Time.deltaTime, _spriteRenderer.size.y);

        if(_spriteRenderer.size.x > groundWidth)
        {
            _spriteRenderer.size = startSize;
        }
    }
}
