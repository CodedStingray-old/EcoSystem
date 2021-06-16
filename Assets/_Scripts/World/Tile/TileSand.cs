using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSand : Tile {
    public override bool CanGrowGrass() {
        return true;
    }

    public override bool CanGrowTrees() {
        return false;
    }

    public override bool IsWalkable() {
        return true;
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
