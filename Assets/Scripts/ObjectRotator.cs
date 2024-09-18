using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public float rotationSpeed = 100f;  // Velocidade de rotação
    private Vector3 previousMousePosition;  // Posição anterior do mouse
    private Vector2 previousTouchPosition;  // Posição anterior do toque no celular

    void Update()
    {
        // Armazena a posição inicial para manter o objeto fixo
        Vector3 initialPosition = transform.position;

        // Detectar rotação com o mouse no editor ou desktop
        if (Input.GetMouseButton(0))  // Botão esquerdo do mouse pressionado
        {
            Vector3 deltaMousePosition = Input.mousePosition - previousMousePosition;

            // Rotaciona em torno do eixo Y com o movimento horizontal (em relação ao eixo local)
            transform.Rotate(Vector3.up, -deltaMousePosition.x * rotationSpeed * Time.deltaTime, Space.Self);

            // Rotaciona em torno do eixo X com o movimento vertical (opcional)
            transform.Rotate(Vector3.right, deltaMousePosition.y * rotationSpeed * Time.deltaTime, Space.Self);

            previousMousePosition = Input.mousePosition;  // Atualiza a posição anterior do mouse
        }

        // Detectar rotação com toque em dispositivos móveis
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);  // Captura o primeiro toque

            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 deltaTouchPosition = touch.deltaPosition;

                // Rotaciona em torno do eixo Y com o movimento horizontal (em relação ao eixo local)
                transform.Rotate(Vector3.up, -deltaTouchPosition.x * rotationSpeed * Time.deltaTime, Space.Self);

                // Rotaciona em torno do eixo X com o movimento vertical (opcional)
                transform.Rotate(Vector3.right, deltaTouchPosition.y * rotationSpeed * Time.deltaTime, Space.Self);
            }

            previousTouchPosition = touch.position;  // Atualiza a posição anterior do toque
        }

        // Manter o objeto na mesma posição para evitar que ele se mova
        transform.position = initialPosition;
    }
}
