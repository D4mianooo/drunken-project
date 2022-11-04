using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) {
        if (collision.transform.tag != "Player") return;
        collision.transform.GetComponent<PlayerMovement>().enabled = false;
        collision.transform.GetComponent<PlayerHealth>().ProcessDie();
        Debug.Log("dies from cringe!");
    }
}
