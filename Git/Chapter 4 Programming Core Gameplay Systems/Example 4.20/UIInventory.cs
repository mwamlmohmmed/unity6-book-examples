using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class UIInventory : MonoBehaviour {
    public static UIInventory Instance;
    public Transform gridContainer;
    public GameObject inventorySlotPrefab;
    public GameObject inventoryPanel; // Whole UI panel
    public Button toggleButton;

    void Awake()  {
        Instance = this;
        if (toggleButton != null)
        toggleButton.onClick.AddListener(ToggleInventoryUI);
    }
    public void RefreshInventory()  {
        foreach (Transform child in gridContainer)
            Destroy(child.gameObject);
        foreach (InventoryItem item in InventoryManager.Instance.items) {
            GameObject slot = Instantiate(inventorySlotPrefab, gridContainer);
            Image iconImage = slot.transform.GetChild(0).GetComponent<Image>();
            TextMeshProUGUI quantityText = slot.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
            iconImage.sprite = item.icon;
         quantityText.text = "x" + item.quantity.ToString();
        }
    }
    public void ToggleInventoryUI() {
        if (inventoryPanel != null)
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
    }
}
