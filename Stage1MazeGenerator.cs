using UnityEngine;

public class Stage1MazeGenerator : MonoBehaviour {
    public int size = 9; // maze size (odd)
    public float wallSize = 1f;
    public GameObject wallPrefab;
    public GameObject floorPrefab;
    public GameObject valvePrefab;
    public int openValves = 0;

    void Start() { GenerateMaze();
        // Place three valves hard-coded positions for the skeleton
        PlaceValve(new Vector3(1.5f, 0.5f, 1.5f));
        PlaceValve(new Vector3(7f, 0.5f, 3f));
        PlaceValve(new Vector3(4f, 0.5f, 7f));
    }

    void GenerateMaze() {
        // Minimal maze-like labyrinth using walls only (no pathfinding; it's a skeleton)
        for (int x = 0; x < size; x++) {
            for (int z = 0; z < size; z++) {
                if (x == 0 || z == 0 || x == size-1 || z == size-1) {
                    CreateWall(x, z);
                } else {
                    // inner walls random to fake a maze for skeleton
                    if (Random.value > 0.8f) CreateWall(x, z);
                }
            }
        }
        // floor
        if (floorPrefab != null) {
            GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
            floor.transform.localScale = new Vector3((size-1)/10f, 1, (size-1)/10f);
            floor.transform.position = new Vector3((size-1)/2f, 0f, (size-1)/2f);
        }
    }

    void CreateWall(int x, int z) {
        if (wallPrefab != null) {
            GameObject w = Instantiate(wallPrefab);
            w.transform.position = new Vector3(x, 0.5f, z);
            w.transform.localScale = new Vector3(1f, 1f, 1f);
        } else {
            // fallback: create a cube
            GameObject w = GameObject.CreatePrimitive(PrimitiveType.Cube);
            w.transform.position = new Vector3(x, 0.5f, z);
            w.transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    void PlaceValve(Vector3 pos){
        if (valvePrefab != null) {
            GameObject v = Instantiate(valvePrefab, pos, Quaternion.identity);
            v.name = "Valve" + openValves;
        } else {
            GameObject v = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            v.transform.position = pos + Vector3.up*0.25f;
            v.name = "ValvePlaceholder";
        }
    }
}
