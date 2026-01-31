using UnityEngine;

public class AudioForCharacterController : MonoBehaviour
{
    public AudioSource audioSource;
    public float activationDistance = 3f;
    
    private CharacterController playerCC;
    private bool played = false;

    void Start()
    {
        // Находим игрока по тегу
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            playerCC = player.GetComponent<CharacterController>();
        }
        
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (playerCC == null) return;
        
        // Проверяем расстояние до игрока
        float distance = Vector3.Distance(transform.position, playerCC.transform.position);
        
        if (distance <= activationDistance && !played)
        {
            audioSource.Play();
            played = true;
            Debug.Log("Игрок вошел в зону!");
        }
        else if (distance > activationDistance)
        {
            played = false;
        }
    }
    
    // Визуализация зоны в редакторе
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, activationDistance);
    }
}