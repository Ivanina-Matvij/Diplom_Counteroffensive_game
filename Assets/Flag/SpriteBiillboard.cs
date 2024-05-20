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
            // ��������� ������ �������, ��� ���� ����������� �� ������
            Quaternion desiredRotation = Quaternion.LookRotation(transform.position - mainCamera.transform.position, Vector3.up);

            if (freezeXZRotation)
            {
                // �������� ������ ���� ������� ������� ���� X �� Z
                float currentRotationX = transform.rotation.eulerAngles.x;
                float currentRotationZ = transform.rotation.eulerAngles.z;

                // ����������� ���� ������� ������� �� Y
                transform.rotation = Quaternion.Euler(currentRotationX, desiredRotation.eulerAngles.y, currentRotationZ);
            }
            else
            {
                // ����������� ����� ������� ��� ���������� ����
                transform.rotation = desiredRotation;
            }
        }
    }
}