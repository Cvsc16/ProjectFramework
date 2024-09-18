using UnityEngine;

public class PinchToZoom : MonoBehaviour
{
    public float zoomSpeed = 0.1f;   // Velocidade de zoom
    public float minScale = 0.5f;    // Escala mínima do objeto
    public float maxScale = 3f;      // Escala máxima do objeto

    void Update()
    {
        // Detectar se há dois toques na tela
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Calcula a distância anterior entre os dois toques
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Distância entre os toques no frame anterior e o atual
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Diferença entre as distâncias calculadas
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // Calcula o novo fator de escala baseado na diferença de magnitude e na velocidade do zoom
            float newScale = transform.localScale.x - deltaMagnitudeDiff * zoomSpeed;

            // Limita o fator de escala entre os valores mínimo e máximo
            newScale = Mathf.Clamp(newScale, minScale, maxScale);

            // Aplica a nova escala ao objeto
            transform.localScale = new Vector3(newScale, newScale, newScale);
        }
    }
}
