using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class bounce : MonoBehaviour
{
  public float bounceForce = 30.0f;
  private Rigidbody rb;
  private int lives = 3;

  public TextMeshProUGUI scoreText;
  public TextMeshProUGUI livesText;
  public int score = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        scoreText.text = "Score : " + score;
        livesText.text = "Lives : " + lives;
    }

    private void OnCollisionEnter(Collision collision)
    {
         if (collision.gameObject.CompareTag("Platform")){
            Vector3 bounceDirection = new Vector3(Random.Range(5f, -5f), 5f, Random.Range(-5f, 5f)).normalized;
            rb.AddForce(bounceDirection * bounceForce, ForceMode.VelocityChange);
            score ++;
            scoreText.text = "Score : " + score;
         }
         if (collision.gameObject.CompareTag("Ground")){
            lives--;
            Vector3 Respawnpos = new Vector3 (0f, 15f, 0f);
            transform.position = Respawnpos;
            livesText.text = "Lives : " + lives;
         }
    }
  void Update() {
    if(lives < 1){
      SceneManager.LoadScene(0);
    }
    PlayerPrefs.SetInt("Score", score);
    PlayerPrefs.Save();
  }


}
