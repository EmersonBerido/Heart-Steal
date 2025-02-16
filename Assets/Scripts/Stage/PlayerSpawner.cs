using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    SpriteRenderer rend;
    public float disappearTime = 2.0f;
    private float timer = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2.5)
        {
            rend.color = new Color(rend.color.r, rend.color.g, rend.color.b, rend.color.a - Time.deltaTime * disappearTime);
        }
        if (rend.color.a <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
