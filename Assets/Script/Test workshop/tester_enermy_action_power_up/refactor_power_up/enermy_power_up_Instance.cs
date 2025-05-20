using UnityEngine;
using UnityEditor;

public class enermy_power_up_Instance : MonoBehaviour
{
    // Snippet of a MonoBehaviour that would control motion of a specific vehicle.
    // In PlayMode it accelerates up to the maximum speed permitted by its type


    [Range(0f, 9999f)]
    public float m_current_hp;

    [Range(0f, 9999f)]
    public float m_current_attack;

    // Reference to the ScriptableObject asset
    public enermy_power_up_TypeInfo m_enermy_power_up_Type;

    public void Initialize(enermy_power_up_TypeInfo enermy_power_up_Type)
    {

        /*
        m_VehicleType = vehicleType;
        m_CurrentSpeed = 0f;
        m_Acceleration = Random.Range(0.05f, m_VehicleType.m_MaxAcceration);
        */

        m_enermy_power_up_Type = enermy_power_up_Type;
        m_current_attack = enermy_power_up_Type.m_default_attack;
        m_current_hp = enermy_power_up_Type.m_MaxHP;
    }

    void Update()
    {

        /*

        m_CurrentSpeed += m_Acceleration * Time.deltaTime;

        // Use parameter from the ScriptableObject to control the behaviour of the Vehicle
        if (m_VehicleType && m_VehicleType.m_MaxSpeed < m_CurrentSpeed)
            m_CurrentSpeed = m_VehicleType.m_MaxSpeed;

        gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * m_CurrentSpeed;

        */

        //if press H will increate current_hp;

        //if press a will increate current_attack

        if (Input.GetKeyDown(KeyCode.H))
        {
            m_current_hp += m_enermy_power_up_Type.increate_power_up_hp;
            print("if press H will increate current_hp "+ m_enermy_power_up_Type.increate_power_up_hp);
            print("and now current_hp " + m_current_hp);
            // print("if press H will increate current_hp;");
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            m_current_attack += m_enermy_power_up_Type.increate_power_up_attack;
            print("if press A will increate current_attack " + m_enermy_power_up_Type.increate_power_up_attack);
            print("and now current_attack " + m_current_attack);
            // print("if press A will increate current_attack");
        }

    }

}


public class ScriptableObject_enermy_power_up
{
    [MenuItem("Example_enermy_power_up/Setup ScriptableObject enermy_power_up Example")]
    static void MenuCallback()
    {
        // This example programmatically performs steps that would typically be performed from the Editor's user interface
        // to creates a simple demonstration.  When going into Playmode the three objects will move according to the limits
        // set by their vehicle type.

        // Step 1 - Create or reload the assets that store each VehicleTypeInfo object.
        enermy_power_up_TypeInfo enermy_01 = AssetDatabase.LoadAssetAtPath<enermy_power_up_TypeInfo>("Assets/Script/Test workshop/tester_enermy_action_power_up/refactor_power_up/enermy_power_up_Type_prototype_enermy01.asset");
        if (enermy_01 == null)
        {
            // Create and save ScriptableObject because it doesn't exist yet
            enermy_01 = ScriptableObject.CreateInstance<enermy_power_up_TypeInfo>();
          //  enermy_01.m_MaxHP = 5f;
         // enermy_01.m_MaxHP = 
          //  enermy_01.m_default_attack = 0.5f;
            AssetDatabase.CreateAsset(enermy_01, "Assets/Script/Test workshop/tester_enermy_action_power_up/refactor_power_up/enermy_power_up_Type_prototype_enermy01.asset");

            Debug.Log("success create enermy_01 ");
        }

        /*

        VehicleTypeInfo cruiser = AssetDatabase.LoadAssetAtPath<VehicleTypeInfo>("Assets/VehicleTypeCruiser.asset");
        if (cruiser == null)
        {
            cruiser = ScriptableObject.CreateInstance<VehicleTypeInfo>();
            cruiser.m_MaxSpeed = 75f;
            cruiser.m_MaxAcceration = 2f;
            AssetDatabase.CreateAsset(cruiser, "Assets/VehicleTypeCruiser.asset");
        }
        */


        // Step 2 - Create some example vehicles in the current scene
        {
            var enermy = GameObject.CreatePrimitive(PrimitiveType.Capsule);

            enermy.name = "Enermy_01";
            var enermyBehaviour = enermy.AddComponent<enermy_power_up_Instance>();                       //if you want to add something on create item you must have to assign VehicleInstance : MonoBehaviour
                                                                                                         // and that if you got it ,yes value erverything you must to add or assign on VehicleTypeInfo : ScriptableObject (first!!)
            enermyBehaviour.Initialize(enermy_01);                                                        // and that can assign on VehicleInstance : MonoBehaviour to modify edit on ScriptableObjectVehicleExample class (data bind)
           // vehicleBehaviour.Initialize(enermy_01);
        }


        /*

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


        */
    }
}

