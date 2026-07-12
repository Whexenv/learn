using UnityEngine;

public class ballcontrol : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    // Eğer fiziksel çarpışma (sekme) varsa bunu kullanmalısın:
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("olise"))
        {
            print("Ball hit the ground");
           
        }
        
    }
}