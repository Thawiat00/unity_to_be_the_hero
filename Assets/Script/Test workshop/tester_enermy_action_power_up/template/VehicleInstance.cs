using UnityEngine;
using UnityEditor;

public class VehicleInstance : MonoBehaviour
{

    // Snippet of a MonoBehaviour that would control motion of a specific vehicle.
    // In PlayMode it accelerates up to the maximum speed permitted by its type

    [Range(0f, 200f)]
    public float m_CurrentSpeed;

    [Range(0f, 50f)]
    public float m_Acceleration;

    // Reference to the ScriptableObject asset
    public VehicleTypeInfo m_VehicleType;

    public void Initialize(VehicleTypeInfo vehicleType)
    {
        m_VehicleType = vehicleType;
        m_CurrentSpeed = 0f;
        m_Acceleration = Random.Range(0.05f, m_VehicleType.m_MaxAcceration);
    }

    void Update()
    {
        m_CurrentSpeed += m_Acceleration * Time.deltaTime;

        // Use parameter from the ScriptableObject to control the behaviour of the Vehicle
        if (m_VehicleType && m_VehicleType.m_MaxSpeed < m_CurrentSpeed)
            m_CurrentSpeed = m_VehicleType.m_MaxSpeed;

        gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * m_CurrentSpeed;
    }



}



public class ScriptableObjectVehicleExample
{
    [MenuItem("Example/Setup ScriptableObject Vehicle Example")]
    static void MenuCallback()
    {
        // This example programmatically performs steps that would typically be performed from the Editor's user interface
        // to creates a simple demonstration.  When going into Playmode the three objects will move according to the limits
        // set by their vehicle type.

        // Step 1 - Create or reload the assets that store each VehicleTypeInfo object.
        VehicleTypeInfo wagon = AssetDatabase.LoadAssetAtPath<VehicleTypeInfo>("Assets/VehicleTypeWagon.asset");
        if (wagon == null)
        {
            // Create and save ScriptableObject because it doesn't exist yet
            wagon = ScriptableObject.CreateInstance<VehicleTypeInfo>();
            wagon.m_MaxSpeed = 5f;
            wagon.m_MaxAcceration = 0.5f;
            AssetDatabase.CreateAsset(wagon, "Assets/VehicleTypeWagon.asset");
        }

        VehicleTypeInfo cruiser = AssetDatabase.LoadAssetAtPath<VehicleTypeInfo>("Assets/VehicleTypeCruiser.asset");
        if (cruiser == null)
        {
            cruiser = ScriptableObject.CreateInstance<VehicleTypeInfo>();
            cruiser.m_MaxSpeed = 75f;
            cruiser.m_MaxAcceration = 2f;
            AssetDatabase.CreateAsset(cruiser, "Assets/VehicleTypeCruiser.asset");
        }

        // Step 2 - Create some example vehicles in the current scene
        {
            var vehicle = GameObject.CreatePrimitive(PrimitiveType.Sphere);
           
            vehicle.name = "Wagon1";
            var vehicleBehaviour = vehicle.AddComponent<VehicleInstance>(); //if you want to add something on create item you must have to assign VehicleInstance : MonoBehaviour
                                                                            // and that if you got it ,yes value erverything you must to add or assign on VehicleTypeInfo : ScriptableObject (first!!)
                                                                            // and that can assign on VehicleInstance : MonoBehaviour to modify edit on ScriptableObjectVehicleExample class (data bind)
            vehicleBehaviour.Initialize(wagon);
        }

        {
            var vehicle = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            vehicle.name = "Wagon2";
            var vehicleBehaviour = vehicle.AddComponent<VehicleInstance>();
            vehicleBehaviour.Initialize(wagon);
        }

        {
            var vehicle = GameObject.CreatePrimitive(PrimitiveType.Cube);
            vehicle.name = "Cruiser1";
            var vehicleBehaviour = vehicle.AddComponent<VehicleInstance>();
            vehicleBehaviour.Initialize(cruiser);
        }


        //overview
        // you must have at least 1 scritable object (VehicleTypeInfo : ScriptableObject)
        // and then do create some class mono to handle call back same(run or move something ) on clone object monobehavior (VehicleInstance : MonoBehaviour )
        // and then final create callback to clone command and create object to do some behavior  (class ScriptableObjectVehicleExample) everytime  you click to do command callback then will do some task for you


    }
}
