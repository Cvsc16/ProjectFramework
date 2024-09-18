using UnityEngine;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject ossoModel;      // Referência ao modelo de ossos
    public GameObject cerebroModel;   // Referência ao modelo de cérebro
    public GameObject outroModel;     // Referência ao modelo de corpo feminino

    void Start()
    {
        // Ao iniciar o app, mostramos apenas o modelo de ossos
        ossoModel.SetActive(true);    // Ativa o modelo de ossos
        cerebroModel.SetActive(false); // Desativa o modelo de cérebro
        outroModel.SetActive(false);   // Desativa o modelo de corpo feminino
    }

    public void ShowOssos()
    {
        HideAllModels();
        ossoModel.SetActive(true);  // Mostra o modelo de ossos
    }

    public void ShowCerebro()
    {
        HideAllModels();
        cerebroModel.SetActive(true);  // Mostra o modelo de cérebro
    }

    public void ShowOutroModel()
    {
        HideAllModels();
        outroModel.SetActive(true);  // Mostra o modelo de corpo feminino
    }

    private void HideAllModels()
    {
        ossoModel.SetActive(false);   // Desativa o modelo de ossos
        cerebroModel.SetActive(false);  // Desativa o modelo de cérebro
        outroModel.SetActive(false);   // Desativa o modelo de corpo feminino
    }
}
