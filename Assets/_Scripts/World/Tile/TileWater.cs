using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileWater : Tile {
    public override bool CanGrowGrass() {
        return false;
    }

    public override bool CanGrowTrees() {
        return false;
    }

    public override bool IsWalkable() {
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
