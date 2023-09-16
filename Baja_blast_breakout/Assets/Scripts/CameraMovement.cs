using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   public float speed = 1f;
   public bounce scorescript;

   private AudioSource music;

   void start(){
    music = GetComponent<AudioSource>();
    music.Play();
   }
   
    void Update()
    {
        if (scorescript.score > 5){
        transform.Rotate(Vector3.forward, speed * Time.deltaTime);
        }
    }
}
