using UnityEngine;

// Кристалл маны: вращается, при касании игрока добавляет очки и исчезает.
[RequireComponent(typeof(Collider))]
public class ManaCrystal : MonoBehaviour
{
    [SerializeField] private int pointsValue = 10;
    [SerializeField] private float spinSpeed = 90f;

    private void Reset()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    private void Update()
    {
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        ScoreBoard.Instance.AddPoints(pointsValue);
        Destroy(gameObject);
    }
}