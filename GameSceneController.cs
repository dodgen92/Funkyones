using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    public int boardWidth = 6;
    public int boardHeight =5;
    public float pieceSpacing = 1.4f;

///references
    public Camera gameCamera;
    public Transform levelcontainer;

    public GameObject piecePrefab

///internal variables
    private int score;
    private bool gameOver;

    private Piece[,] board;
    private Piece selectedPiece;


    void Start()
    {
        BuildBoard ();
    }


///forloop to instantiate game pieces

    private void BuildBoard() {
        board = new Piece[boardWidth, boardHeight];




        for (int y = 0; y < boardHeight; y++) {
            for (int x = 0; x< boardWidth; x++) {
                GameObject pieceObject = Instantiate (piecePrefab);
                pieceObject.transform.SetParent (levelContainer);
                pieceObject.transform.localPosition = new Vector3(

                    ///horizontal
                    (-boardWidth * pieceSpacing) / 2f +(pieceSpacing / 2f) + x * pieceSpacing

                    ///vertical
                    (-boardHeight * pieceSpacing) / 2f + (pieceSpacing / 2f) + y * pieceSpacing
                    0
                );

                Piece piece = pieceObject.GetComponent<Piece> ();
                piece.coordinates = new Vector2 (x, y);

                board [x, y] = piece;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
