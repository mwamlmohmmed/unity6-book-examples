 public GameObject doorToOpen;            
    private bool playerNearby = false;
    void Update()   {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))  {
            Debug.Log("Lever pulled! Door opened.");
            doorToOpen.SetActive(false);
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player")) {
            playerNearby = true;
       Debug.Log("Player near lever. Press E to interact.");
        }
    }
    void OnTriggerExit2D(Collider2D other)   {
        if (other.CompareTag("Player"))   {
            playerNearby = false;
            Debug.Log("Player left lever area.");
        }
    }
