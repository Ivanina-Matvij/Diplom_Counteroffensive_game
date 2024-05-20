using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField] private bool freezeXZRotation = true;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (mainCamera != null)
        {
            // Обчислити бажану ротацію, щоб бути спрямованим до камери
            Quaternion desiredRotation = Quaternion.LookRotation(transform.position - mainCamera.transform.position, Vector3.up);

            if (freezeXZRotation)
            {
                // Зберегти поточні кути ротації навколо осей X та Z
                float currentRotationX = transform.rotation.eulerAngles.x;
                float currentRotationZ = transform.rotation.eulerAngles.z;

                // Застосувати нову ротацію навколо осі Y
                transform.rotation = Quaternion.Euler(currentRotationX, desiredRotation.eulerAngles.y, currentRotationZ);
            }
            else
            {
                // Застосувати повну ротацію без блокування осей
                transform.rotation = desiredRotation;
            }
        }
    }
}