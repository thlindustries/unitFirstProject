using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 cameraPosition;
    // Update is called once per frame
    void Update() {
        cameraPosition.x = player.position.x;
        cameraPosition.y = player.position.y+2;
        cameraPosition.z = player.position.z-6;

        transform.position = cameraPosition;
    }
}
