using TMPro;
using UnityEngine;

public class Win : MonoBehaviour
{
    public TMP_Text loose;
    private void OnCollisionEnter(Collision collision)
    {
        print("�� ������� ���");
        loose.gameObject.SetActive(true);
    }
}
