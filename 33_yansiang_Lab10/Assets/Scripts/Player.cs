using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float speed;
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4, 4), 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
            Invoke("GameOver", 1);
    }
    private void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
