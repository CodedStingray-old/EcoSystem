using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour {

    public static readonly int width = 64;
    public static readonly int height = 64;

    private Tile[,] grid = new Tile[width, height];

    private Dictionary<int, Tile> mappedTiles = new Dictionary<int, Tile>();

    [SerializeField]
    private TileWater tileWaterPrefab;
    [SerializeField]
    private TileShallowWater tileShallowWaterPrefab;
    [SerializeField]
    private TileSand tileSandPrefab;
    [SerializeField]
    private TileGrass tileGrassPrefab;
    [SerializeField]
    private TileStone tileStonePrefab;

    void Start() {
        mappedTiles[-8] = tileWaterPrefab;
        mappedTiles[-7] = tileWaterPrefab;
        mappedTiles[-6] = tileWaterPrefab;
        mappedTiles[-5] = tileWaterPrefab;
        mappedTiles[-4] = tileWaterPrefab;
        mappedTiles[-3] = tileWaterPrefab;

        mappedTiles[-2] = tileShallowWaterPrefab;
        mappedTiles[-1] = tileShallowWaterPrefab;

        mappedTiles[0] = tileSandPrefab;
        mappedTiles[1] = tileSandPrefab;
        mappedTiles[2] = tileSandPrefab;

        mappedTiles[3] = tileGrassPrefab;
        mappedTiles[4] = tileGrassPrefab;
        mappedTiles[5] = tileGrassPrefab;
        mappedTiles[6] = tileGrassPrefab;
        mappedTiles[7] = tileGrassPrefab;
        mappedTiles[8] = tileGrassPrefab;

        mappedTiles[9] = tileStonePrefab;
        mappedTiles[10] = tileStonePrefab;
        mappedTiles[11] = tileStonePrefab;
        mappedTiles[12] = tileStonePrefab;

        GenerateWorld();
    }

    void Update() {

    }

    private void GenerateWorld() {
        Debug.Log("Geenerating World");
        for(int x = 0; x < width; x++) {
            for(int y = 0; y < height; y++) {
                grid[x, y] = Instantiate(mappedTiles[0]);
                grid[x, y].transform.position = new Vector3(x, 0, y);
            }
        }
    }
}
