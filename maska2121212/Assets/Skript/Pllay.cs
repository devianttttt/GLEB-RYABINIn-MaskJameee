using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Название сцены для загрузки
    public string sceneName;
    
    // Функция, которая вызывается при нажатии на кнопку
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    
    // Альтернативный вариант: переход по индексу сцены
    public void ChangeSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    
    // Вариант с асинхронной загрузкой (без зависания игры)
    public void ChangeSceneAsync()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }
}