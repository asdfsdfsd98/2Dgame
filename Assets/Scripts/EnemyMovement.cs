using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Vector2 lastPos;
    private SpriteRenderer sprite;
    private void Start()
    {
        
        sprite = GetComponent<SpriteRenderer>();

    }
    private void Update()

    {
        Vector2 currentPos = transform.position;
        
        Vector2 deltaPos = currentPos - lastPos;
        
        if (deltaPos.x >= 0)
            sprite.flipX = false;
        else
            sprite.flipX = true;

        lastPos = transform.position;
    }
}
