using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    SpriteRenderer rend;
    public float disappearTime = 2.0f;
    private bool isDisappearing = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDisappearing)
        {
            rend.color = new Color(rend.color.r, rend.color.g, rend.color.b, rend.color.a - Time.deltaTime * disappearTime);
        }
        if (rend.color.a <= 0)
        {
            gameObject.SetActive(false);
        }
    }
    public void disappear()
    {
        isDisappearing = true;
    }
}
