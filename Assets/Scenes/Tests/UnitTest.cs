using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class UnitTest
{
    [Test]
    public void TestSpeedInitialized()
    {
        // ��������� ��������� GameObject � ����������� Movement
        var gameObject = new GameObject();
        var movement = gameObject.AddComponent<Movement>();

        // ����������, �� �������� ������������ � ��������� �� ������������� (5f)
        Assert.AreEqual(5f, movement.speed, "Speed was not initialized correctly");

        // ������� ������� ��'����
        Object.DestroyImmediate(gameObject);
    }

    [Test]
    public void TestRotationSpeedInitialized()
    {
        // ��������� ��������� GameObject � ����������� Movement
        var gameObject = new GameObject();
        var movement = gameObject.AddComponent<Movement>();

        // ����������, �� rotationSpeed ������������ � ��������� 50f
        Assert.AreEqual(50f, movement.rotationSpeed, "Rotation speed was not initialized correctly");

        // ������� ������� ��'����
        Object.DestroyImmediate(gameObject);
    }
}