using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float sensitivity = 10f;
    private bool isRotating = false;

    void Update()
    {
        // Detectar quando o botão esquerdo do mouse é pressionado
        if (Input.GetMouseButtonDown(0))
        {
            isRotating = true;
        }

        // Detectar quando o botão esquerdo do mouse é solto
        if (Input.GetMouseButtonUp(0))
        {
            isRotating = false;
        }

        // Aplicar rotação enquanto o botão esquerdo está pressionado (desktop)
        if (isRotating)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

            // Rotacionar o objeto em torno de seus eixos locais
            transform.Rotate(Vector3.up, -mouseX, Space.Self); // Rotação em torno do eixo Y
            transform.Rotate(Vector3.right, mouseY, Space.Self); // Rotação em torno do eixo X
        }

        // Detectar toques na tela (mobile)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float touchX = touch.deltaPosition.x * sensitivity * Time.deltaTime;
                float touchY = touch.deltaPosition.y * sensitivity * Time.deltaTime;

                // Rotacionar o objeto em torno de seus eixos locais com toque
                transform.Rotate(Vector3.up, -touchX, Space.Self); // Rotação em torno do eixo Y
                transform.Rotate(Vector3.right, touchY, Space.Self); // Rotação em torno do eixo X
            }
        }
    }
}
