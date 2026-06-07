using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float speed = 5f;
    public float fastspeed = 50f;
    public float slowspeed = 2f ;

    public float currentSpeed;
    public bool control_dead;

    public GameObject player;
    public GameObject gun;
    public GameObject gun2;



    void Start()
    {
        currentSpeed = speed; 
    }

    void Update()
    {
       if (control_dead == true)
        {
            Destroy(player);
            print("Yaşamadan nasıl yürücen Babo");
        }
        
       
        if (Input.GetKey(KeyCode.LeftShift))
        {

            currentSpeed = fastspeed;

        }
      
         else if (Input.GetKey(KeyCode.LeftControl))
        {

            currentSpeed = slowspeed;

        }
        else
        {
            currentSpeed = speed;

        }



        if (Input.GetKey(KeyCode.W))
        {

            transform.position += Vector3.forward * currentSpeed*Time.deltaTime;
        
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.position += Vector3.left * currentSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.position += Vector3.back * currentSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.position += Vector3.right * currentSpeed * Time.deltaTime;

        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            gun.SetActive(true);
            gun2.SetActive(false);

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gun2.SetActive(true);
            gun.SetActive(false);

        }


    }
}
