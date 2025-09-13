int layerMask = LayerMask.GetMask("Enemy");
RaycastHit hit;
if (Physics.Raycast(transform.position, transform.forward, out hit, 100f, layerMask)) {
    Debug.Log("Hit an enemy!");
}   