using UnityEngine;

public class HedgehogManager : MonoBehaviour
{
    public float speed = 5;
    public float damage = 12;
    private Vector2 pos;
    public bool goingLeft = true;

    // Update is called once per frame
    void Update()
    {
        /*if(goingLeft)
        {
            Debug.Log("Going Left");*/
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        /*}

        if(!goingLeft)
        {
            Debug.Log("Going Right");
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }*/
        if (transform.position.x < -pos.x)
        {
            goingLeft = false;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (transform.position.x > pos.x)
        {
            goingLeft = true;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    void Start()
    {
        pos = transform.position;
    }
}
