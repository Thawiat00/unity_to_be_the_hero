using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Test_wave_spawn
{
    // A Test behaves as an ordinary method
    [Test]
    public void Test_setup_get_point_spawn_enermy_equal_0()
    {
        // Arrange
        var gameObject = new GameObject();
        var spawn = gameObject.AddComponent<spawn_wave_enermy>();

        // Act
        spawn.setup_get_point_spawn_enermy();

        // Assert
        Assert.AreEqual(0, spawn.current_list_point);

    }




    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.

    /*
    [UnityTest]
    public IEnumerator Test_wave_spawnWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
    */
}
