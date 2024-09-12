using UnityEngine;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject ossoModel;
    public GameObject cerebroModel;
    public GameObject outroModel;

public void ShowOssos()
{
    Debug.Log("Showing Ossos");
    HideAllModels();
    ossoModel.SetActive(true);
}

public void ShowCerebro()
{
    HideAllModels();
    cerebroModel.SetActive(true);  // Ativa o modelo de cérebro
}

public void ShowOutroModel()
{
    HideAllModels();
    outroModel.SetActive(true);  // Ativa o modelo de corpo feminino
}

private void HideAllModels()
{
    Debug.Log("Hiding all models");

    ossoModel.SetActive(false);
    cerebroModel.SetActive(false);
    outroModel.SetActive(false);
}
}
