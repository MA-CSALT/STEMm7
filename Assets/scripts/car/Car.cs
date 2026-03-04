using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private float speed;
    [SerializeField] GameObject frontTire;
    [SerializeField] GameObject backTire;

    Vector2 minScale, maxScale;
    

    void Start()
    {
        minScale = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxScale = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        speed = Input.GetAxis("Horizontal") ;

        backTire.transform.Rotate(0,0,-speed * 2f);
        frontTire.transform.Rotate(0,0,-speed * 2f);

        transform.Translate(Vector3.right * speed * Time.deltaTime * 10f);

        if(transform.position.x < minScale.x)
        {
            transform.position = new Vector3(maxScale.x,0,0);
        }

        if (transform.position.x > maxScale.x)
        {
            transform.position = new Vector3(minScale.x, 0, 0);
        }
    }
}
