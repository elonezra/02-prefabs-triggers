using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiled_effect : MonoBehaviour
{
    public float maxOpacity = 0.5f;
    public float fadeSpeed = 1.0f;
    public float fadeDuration = 5.0f;
    private SpriteRenderer shieldSprite;
    private bool isFading = false;
    private float fadeStartTime;

    private void Start()
    {
        shieldSprite = GetComponent<SpriteRenderer>();
        shieldSprite.color = new Color(1f, 1f, 1f, 0f);
    }

    private void Update()
    {
        if (isFading)
        {
            float timeSinceFadeStarted = Time.time - fadeStartTime;
            float fadeProgress = timeSinceFadeStarted / fadeDuration;
            float opacity = Mathf.Lerp(maxOpacity, 0f, fadeProgress);
            shieldSprite.color = new Color(1f, 1f, 1f, opacity);

            if (fadeProgress >= 1f)
            {
                isFading = false;
            }
        }
        else
        {
            float opacity = 0;
            shieldSprite.color = new Color(1f, 1f, 1f, opacity);
        }
    }

    public void StartFade()
    {
        isFading = true;
        fadeStartTime = Time.time;
    }
}
