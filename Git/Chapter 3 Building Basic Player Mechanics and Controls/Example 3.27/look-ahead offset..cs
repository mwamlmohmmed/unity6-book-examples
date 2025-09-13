public static CameraShaker Instance;        
private Vector3 originalPos;
    void Awake() {
        Instance = this;
        originalPos = transform.localPosition;
    }
    public void Shake(float duration, float magnitude) {
        StartCoroutine(ShakeRoutine(duration, magnitude));
    }
    private IEnumerator ShakeRoutine(float duration, float magnitude) {
        float elapsed = 0f;
        while (elapsed < duration) {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;
            transform.localPosition = originalPos + new Vector3(x, y, 0f);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPos;
    }
    