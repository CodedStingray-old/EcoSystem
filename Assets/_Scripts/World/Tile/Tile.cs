using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Tile : MonoBehaviour {

    private Vector2Int gridPosition;

    public float heightScale = 1;

    public Vector2Int GridPosition {
        get => gridPosition;
        set {
            if(gridPosition == null) {
                gridPosition = value;
            } else {
                throw new System.InvalidOperationException("Position can only be set once.");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract bool IsWalkable();

    public abstract bool CanGrowGrass();

    public abstract bool CanGrowTrees();
}
