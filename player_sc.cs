using UnityEngine;

public class player_sc : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 3;
    void Start()
    {
      //  transform.position += new Vector3(10,0,0);  //bir kez konum değiştirme
    }

    // Update is called once per frame
    void Update()
    {
       //  transform.position += new Vector3(5f,0,0*speed*Time.deltaTime);   //sürekli konum değiştirme
       // transform.position += new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0*speed*Time.deltaTime);  //klavyeden input alarak konum değiştirme
    }
    
}
