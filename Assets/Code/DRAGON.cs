using UnityEngine;

public class DRAGON : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float Speed = .1f;
    public Transform ShootPoint;
    GameObject player;
    public GameObject CheckPoint;

    public GameObject FireBall;
    float fireRate;
    float nextFire;

    public AudioClip Die;
    public AudioClip Fire;
    public AudioClip Roar;
    public AudioClip Roar2;
    public AudioSource Dragon;
    // Start is called before the first frame update
    void Start()
    {
        Rb.velocity = new Vector2(Rb.velocity.x, Speed * 1);

        fireRate = 3f;
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //CheckIfTimeToFire();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Dragon.PlayOneShot(Die);

            player = FindObjectOfType<PlayerMovement>().gameObject;
            player.transform.position = CheckPoint.transform.position;
            transform.position = new Vector3(.57f, 3.75f, 0);
            var FireBalls = FindObjectsOfType<FireBall>();
            //for loop fireballs[i] != this
            for (int i = 0; i >= FireBalls.Length; i++)
            {
                Destroy(FireBalls[i].gameObject);
            }

            print("bonk");
        }
    }

    void CheckIfTimeToFire()
    {
        // if(Time.time > nextFire)

        Instantiate(FireBall, ShootPoint.position, Quaternion.identity);
        Dragon.PlayOneShot(Fire);

        //nextFire = Time.time + fireRate;


    }
    public void PlaySound(AudioClip Clip)
    {
        Dragon.PlayOneShot(Clip);
    }
    // public void PlayShootSound(AudioClip ShootClip)
    //{
    //  Dragon.PlayOneShot(ShootClip);
    //}

    /* psuedocode gang
     Dragon attack class
    {
    firball knows player location
    fireball shhots in direction of player location
    speed is constant
    spawn fireball from dragon shoot point
    does not follow player like a missle
    }
     */
}
