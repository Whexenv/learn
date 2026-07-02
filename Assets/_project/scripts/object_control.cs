using UnityEngine;
using UnityEngine.UIElements;

public class object_control : MonoBehaviour
{
    public GameObject enemyprefab;
    public GameObject bulletprefab;
    void Start()
   
    {
        /* GameObject objecect1= new GameObject("Enemy");

          objecect1.transform.position = new Vector3(0, 0.610f, 0);
          new GameObject();*/
        
    
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            var enemy = Instantiate(enemyprefab);
            enemy.transform.position = new Vector3(Random.Range(0f,10f), 0f,Random.Range(0f,10f));
            print(enemy.transform.position+" "+"was created");
            return;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            var newbullet = Instantiate(bulletprefab,Vector3.zero,Quaternion.identity);

        }


    }
}
