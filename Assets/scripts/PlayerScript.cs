using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerScript : MonoBehaviour
{
    public float speed;

    public string MovimentAxesName;

    public bool isPlayer = true;
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {

        if (isPlayer)
            spriteRenderer.color = saveController.Instance.colorPlayer;
        else
            spriteRenderer.color = saveController.Instance.colorEnemy;

    }
    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis(MovimentAxesName);

        Vector3 newPosition = transform.position + Vector3.up * moveInput * speed * Time.deltaTime;

        newPosition.y = Mathf.Clamp(newPosition.y, -4.5f, 4.5f);

        transform.position = newPosition;
    }
}
