using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chips : MonoBehaviour
{
    [SerializeField] private Color _chipColor;
    [SerializeField] private SpriteRenderer _colorRenderer;
    void Start()
    {
        getChips();
    }
    void getChips()
    {
        for(int i = 0; i< 5; i++)
        {
          for(int j = 0; j<20; j++)
            {
                if (i == 0)
                {
                    Debug.Log("Chip " + i + "-" + j + " is a king chip" );
                    _colorRenderer.color = _chipColor;
                }
                if (i == 1)
                {
                    Debug.Log("Chip " + i + "-" + j + " is a rook chip");
                    _colorRenderer.color = _chipColor;
                }
                if (i == 2)
                {
                    Debug.Log("Chip " + i + "-" + j + " is a knight chip");
                    _colorRenderer.color = _chipColor;
                }
                if (i == 3)
                {
                    Debug.Log("Chip " + i + "-" + j + " is a bishop chip");
                    _colorRenderer.color = _chipColor;
                }
                if (i == 4)
                {
                    Debug.Log("Chip " + i + "-" + j + " is a queen chip");
                    _colorRenderer.color = _chipColor;
                }

            }
        }
    }

 
}
