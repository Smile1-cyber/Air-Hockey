using TMPro;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public TextMeshProUGUI player1Text;
    public TextMeshProUGUI player2Text;

    public bool isPlayer1 = true;
    public AudioClip Clip;

    private int player1 = 0;
    private int player2 = 0;
    private AudioSource AudioSource;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Puk"))
        {
            if(isPlayer1)
            {
                player1Text.text = (++player1).ToString();
            }
            else
            {
                player2Text.text = (++player2).ToString();
            }

        }
        AudioSource.PlayOneShot(Clip);
        collision.transform.position = Vector3.zero;
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
