using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject panel; // Сюда перетащи панель
    
    public void TogglePanel()
    {
        panel.SetActive(!panel.activeSelf);
    }
    
    public void ShowPanel()
    {
        panel.SetActive(true);
    }
    
    public void HidePanel()
    {
        panel.SetActive(false);
    }
}
