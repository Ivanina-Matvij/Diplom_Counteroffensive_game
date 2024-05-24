using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class UnitTest
{
    [Test]
    public void TestSpeedInitialized()
    {
        // Створюємо екземпляр GameObject з компонентом Movement
        var gameObject = new GameObject();
        var movement = gameObject.AddComponent<Movement>();

        // Перевіряємо, чи швидкість ініціалізована зі значенням за замовчуванням (5f)
        Assert.AreEqual(5f, movement.speed, "Speed was not initialized correctly");

        // Очищуємо створені об'єкти
        Object.DestroyImmediate(gameObject);
    }

    [Test]
    public void TestRotationSpeedInitialized()
    {
        // Створюємо екземпляр GameObject з компонентом Movement
        var gameObject = new GameObject();
        var movement = gameObject.AddComponent<Movement>();

        // Перевіряємо, чи rotationSpeed ініціалізована зі значенням 50f
        Assert.AreEqual(50f, movement.rotationSpeed, "Rotation speed was not initialized correctly");

        // Очищуємо створені об'єкти
        Object.DestroyImmediate(gameObject);
    }
}