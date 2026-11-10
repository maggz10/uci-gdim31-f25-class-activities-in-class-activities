using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    private GameObject cat;
    private bool isChasing = false;

    private void Awake()
    {
        cat = GameObject.Find("Cat");
    }

    private void Update()
    {
        if(isChasing && cat != null)
        {
            Vector3 direction = (cat.transform.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }

    public void StartChasing()
    {
        isChasing = true;
    }

    public void StopChasing()
    {
        isChasing = false;
    }
}
