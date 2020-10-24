using UnityEngine;

public class AudioCollision : MonoBehaviour
{
    public AudioSource audio;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            audio.Play();
        }
    }
}
