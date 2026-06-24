using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public float speed = 5f;
    public float fastspeed = 50f;
    public float slowspeed = 2f;

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
            print("Yaşamadan nasıl yürücen Babo");
            Destroy(player);
            return;


        }
        MovePlayertest();
        guncontrol();

    }
    private void guncontrol()
    {
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
    void MovePlayertest()
    {
        Vector3 yon = Vector3.zero;

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
            yon += Vector3.forward;

            //  transform.position += Vector3.left * currentSpeed * Time.deltaTime; normalde  böyle yazsak biraz daha uzun oluyor  en üstte vector 3 "yön diye 
            //tanımladığımız değişkeni üst satırda gördüğümüz gibi  tek bir yerden gelmesi lazım  77. satırdada tanımladığımız transform.position yerinde hepsini tek bir transform position na tanımladık 


        }
        if (Input.GetKey(KeyCode.A))
        {
            yon += Vector3.left;


        }
        if (Input.GetKey(KeyCode.S))
        {
            yon += Vector3.back;


        }
        if (Input.GetKey(KeyCode.D))
        {

            yon += Vector3.right;



        }


        transform.position += yon.normalized * Time.deltaTime * currentSpeed;// bu aslında yukarda vector3 yon = Vector3.zero; dediğimizde yönünü sıfırlıyoruz sonra
                                                                             // bu yazdığım transform şeyiyle kullanıcın girdisine göre hızını ayarlıyoruz buda veriyor hızı
                                                                             //alt alta yazmaya dikkat etmek lazım

        //normalized dememizin sebebi çaprak giderken hız artyıor biraz "normalized" dediğimizde bu adı üstünde normal hale geliyor

       

    }

   
}
