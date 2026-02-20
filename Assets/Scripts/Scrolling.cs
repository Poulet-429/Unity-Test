using UnityEngine;

public class Scrolling : MonoBehaviour
{
    private Transform player;

    private void Awake()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 cameraPos = transform.position;
        cameraPos.x = player.position.x;
        cameraPos.y = player.position.y;
        transform.position = cameraPos;
    }
}
