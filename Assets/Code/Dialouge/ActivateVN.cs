using UnityEngine;

public class ActivateVN : MonoBehaviour
{
    public GameObject VNRoot;

    DialougeSystem dialougeSystem;
    Test testInstance;

    public DRAGON DragonSound;
    public GameObject Dragon;
    public AudioClip Roar2;
    public AudioClip BossMusic;
    public AudioClip RestMusic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DragonSound = FindObjectOfType<DRAGON>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            VNRoot.SetActive(true);
            Dragon = FindObjectOfType<DRAGON>().gameObject;
            Destroy(other.gameObject);
            GameController.Gc.CurrentLevel.CurrentState = LevelController.LevelState.dialogue;
            //dialougeSystem.enabled = true;
            // testInstance.enabled = true;
            if (GameController.Gc.Music.clip == BossMusic)
            {

                GameController.Gc.Music.Stop();
                GameController.Gc.Music.clip = RestMusic;
                GameController.Gc.Music.Play();
                DragonSound.PlaySound(DragonSound.Roar2);
                Dragon.SetActive(false);
            }
        }

    }
}
