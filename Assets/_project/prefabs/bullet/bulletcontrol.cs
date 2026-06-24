using UnityEngine;

public class bulletcontrol : MonoBehaviour
{
    public float speed;
    public Vector3 _startposition;//!!!
    void Start()
    {
        _startposition = transform.position;//!!!
    }

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;//!!!
        var distance=(transform.position - _startposition).magnitude;//!!!
        if(distance>50) 
        {
            Destroy(gameObject);//!!!
        }
    }
}

