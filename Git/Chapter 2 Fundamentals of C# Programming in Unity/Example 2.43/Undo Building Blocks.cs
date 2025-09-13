public GameObject blockPrefab;            Example 2.42
    private Stack<GameObject> placedBlocks = new Stack<GameObject>();
    void Update()
{
    if (Input.GetKeyDown(KeyCode.B))
    { // Place a new block
        Vector3 spawnPosition = new Vector3(Random.
       Range(-5f, 5f), Random.Range(-3f, 3f), 0f);
        GameObject newBlock = Instantiate(blockPrefab,
spawnPosition, Quaternion.identity);
        placedBlocks.Push(newBlock);
        Debug.Log("Block placed. Total: " + placedBlocks.Count);
        if (Input.GetKeyDown(KeyCode.U))
        {
            // Undo the last block
            if (placedBlocks.Count > 0)
            {
                GameObject lastBlock = placedBlocks.Pop();
                Destroy(lastBlock);
                Debug.Log("Undid a block. Remaining: " + placedBlocks.Count);
            }
            else
            {
                Debug.Log("No blocks left to undo!");
            }
        }
    }

}