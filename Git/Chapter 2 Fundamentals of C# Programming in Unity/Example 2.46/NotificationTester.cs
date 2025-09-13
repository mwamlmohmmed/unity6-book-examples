public TextMeshProUGUI notificationText;      
    private Coroutine currentRoutine;

    // Overload 1: Default message
    public void ShowNotification() {
        ShowNotification("Default Notification", 2f);
    }

    // Overload 2: Custom message
    public void ShowNotification(string message) {
        ShowNotification(message, 2f);
    }

    // Overload 3: Custom message and duration
public void ShowNotification(string message, float duration){
        if (currentRoutine != null) {
            StopCoroutine(currentRoutine);
        }
        currentRoutine = StartCoroutine(DisplayMessageRoutine(message, duration));
    }
    private IEnumerator DisplayMessageRoutine(string message, float duration)
    {
        notificationText.text = message;
        notificationText.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        notificationText.gameObject.SetActive(false);
    }
