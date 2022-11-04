using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RoadSpawner : MonoBehaviour {
    [SerializeField] private List<GameObject> road;
    [SerializeField] private float offset = 36f;
    void Start(){
        if (road != null && road.Count > 0) {
            road = road.OrderBy(r => r.transform.position.z).ToList();
        }
    }
    public void MoveRoad() {
        GameObject movedRoad = road[0];
        road.Remove(movedRoad);
        road.Add(movedRoad);
        movedRoad.transform.position = new Vector3(0f, 0f, road.Count * offset);
    }
}
