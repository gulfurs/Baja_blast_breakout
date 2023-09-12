using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
  public float bounceForce = 10.0f;

  private Rigidbody rb;
  private int lives = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("Platform"))
         {
            Vector3 bounceDirection = new Vector3(Random.Range(-2f, 2f), 5f, Random.Range(-2f, 2f)).normalized;
             rb.AddForce(bounceDirection * bounceForce, ForceMode.Impulse);
         }
         if (collision.gameObject.CompareTag("Ground")){
            lives--;
            Vector3 Respawnpos = new Vector3 (0f, 15f, 0f);
            transform.position = Respawnpos;
            Debug.Log(lives);
         }
    }
  void Update() {
    if(lives < 1){
      Debug.Log("TABER!");
    }
  }
}
