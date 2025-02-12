using System.Collections;
using TMPro;
using UnityEngine;

public class ButtonSpinner : MonoBehaviour
{
    [SerializeField] private float rotationDuration = 0.5f;
    [SerializeField] private GameObject frontButton;  
    [SerializeField] private GameObject backButton;
    private bool isBackVisible = false;
    private bool isRotating = false;

    public void Flip()
    {
        if (!isRotating)
        {
            StartCoroutine(RotateButton());
        }
    }

    private IEnumerator RotateButton()
    {
        isRotating = true;
        float elapsed = 0;
        float startY = transform.eulerAngles.y;
        float endY = startY + 180f;

        while (elapsed < rotationDuration)
        {
            elapsed += Time.deltaTime;
            float percentage = elapsed / rotationDuration;

            // Use smoothstep for more natural rotation
            float smoothProgress = percentage * percentage * (3f - 2f * percentage);
            float currentY = Mathf.Lerp(startY, endY, smoothProgress);
            transform.eulerAngles = new Vector3(0, currentY, 0);

            // Flip text visibility halfway through
            if (percentage >= 0.5f && !isBackVisible)
            {
                frontButton.gameObject.SetActive(false);
                backButton.gameObject.SetActive(true);
                isBackVisible = true;
            }

            yield return null;
        }

        isRotating = false;
    }
}
