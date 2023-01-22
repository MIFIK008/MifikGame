using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class MyPlayer : MonoBehaviour
{
    public float speed = 2;
    public float turnSpeed = 2;
    public TMP_Text loose;

    private void Update()
    {
        speed += Time.deltaTime / 100;
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(turnSpeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-turnSpeed, 0, 0);
        }
        transform.Translate(0,0, speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("ти лох");
        loose.gameObject.SetActive(true);
    }
    public void Rifht()
    {
        transform.Translate(1, 0, 0);
    }
    public void Left()
    {
        transform.Translate(-1, 0, 0);
    }
}
