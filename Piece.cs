using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    private Color[] colors = new Color[6] 
    {
        Color.red,
        Color.blue,
        Color.green,
        Color.white,
        Color.magenta,
        Color.yellow
    };

    public SpriteRenderer sprite;
   
    public int index;
    public Vector2 coordinates;
    public bool destroyed;
    // 
    void Start()
    {
        index = Random.Range (0, colors.Length);
    
        sprite.color = colors [index];
    
    }

    public bool IsNeighbor (Piece otherPiece) {
        return Mathf.Abs (otherPiece.coordinates.x - this.coordinates.x) + Mathf.Abs(otherPiece.coordinates.y - this.coordinates.y) == 1;
    }

}
