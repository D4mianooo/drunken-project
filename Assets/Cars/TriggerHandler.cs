using UnityEngine;

public class TriggerHandler : MonoBehaviour {
    private RoadSpawner roadSpawner;

    private void Awake() {
        roadSpawner = FindObjectOfType<RoadSpawner>();
    }
    private void OnTriggerEnter(Collider other) {
        if (!other.CompareTag("Player")) return;
        roadSpawner.MoveRoad();
    }
}
