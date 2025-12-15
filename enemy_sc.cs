using UnityEngine;

public class enemy_sc : MonoBehaviour
{
    [SerializeField]
    int speed = 4;

    [SerializeField]
    player_sc player;

    Animator animator;

    AudioSource audioSource;

    //Start is called once
    void Start()
    {
        player=GameObject.Find("Player").GetComponent<player_sc>();
        animator=GetComponent<Animator>();
        audioSource=GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.Log("Enemy_sc::Start audioSource");
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (this.transform.position.y < -5.5f)
        {
            //Destroy(this.gameObject);

            float randomX = Random.Range(-9.5f, 9.5f);



            this.transform.position = new Vector3(Random.Range(-9.5f, 9.5f), 7.4f, 0);

        }
    }

    void OnTiggerEnter2D(Collider2D other)
    {
        Debug.Log("Çarpışma: "+other.tag);

        if (other.tag == "Player")
        {
            //TODO:Player'ın canını bir eksilt
            player_sc player = other.transform.GetComponent<player_sc>();
            player.Damage();
            Destroy(this.gameObject);
        }


        else if (other.tag == "Laser")
        {
            //Çarpıştığı lazeri yok et
            Destroy(other.gameObject);

            if (player != null)
            {
                player.AddScore(10);
            }

            audioSource.Play();
            //Kendini yok et
            Destroy(this.gameObject);
        }
    }

}
