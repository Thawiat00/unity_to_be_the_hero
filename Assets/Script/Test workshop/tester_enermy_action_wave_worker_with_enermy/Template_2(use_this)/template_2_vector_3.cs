using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using static UnityEngine.GraphicsBuffer;


public enum Test_vector_3
{
    Vector3_back,
    Vector3_down,
    Vector3_foward,
    Vector3_left,
    Vector3_negativeInfinity,
    Vector3_one,
    Vector3_positiveInfinity,
    Vector3_right,
    Vector3_up,
    Vector3_zero,
    Vector3_magnitude,
    Vector3_Normalize,
    Vector3_sqrMagnitude,
    Vector3_this_int_,
    Vector3_consturcter,
    Vector3_Angle,
    Vector3_Vector3_ClampMagnitude,
    Vector3_Cross,
    Vector3_Distance,
    Vector3_Dot,
    Vector3_Lerp,
    Vector3_LerpUnclamped,
    Vector3_Max,
    Vector3_Min,
    Vector3_MoveTowards,
    Vector3_Normalize_void,
    Vector3_Vector3_OrthoNormalize,
    Vector3_Project,
    Vector3_ProjectOnPlane,
    Vector3_Reflect,
    Vector3_RotateTowards,
    Vector3_Scale,
    Vector3_SignedAngle,
    Vector3_Slerp,
    Vector3_SlerpUnclamped,
    Vector3_SmoothDamp,

}




public class template_2_vector_3 : MonoBehaviour
{

    [SerializeField]
   private  Test_vector_3 test_Vector_3;



    //help sqrMagnitude
    #nullable enable
    public Transform? other_sqrMagnitude;
    public float closeDistance = 5.0f;


    //help Vector3.this[int]
    public Vector3 p;


    //help Vector3_consturcter
    Vector3 myVector;
    Rigidbody m_Rigidbody;
    float m_Speed = 2.0f;



    //help Vector3_Angle
    public Transform target_Vector3_Angle;

    // prints "close" if the z-axis of this transform looks
    // almost towards the target



    //help Vector3_ClampMagnitude

    // Move the object around with the arrow keys but confine it
    // to a given radius around a center point.
    public Vector3 centerPt;
    public float radius;




    //help Vector3_Distance

    public Transform otherDistance;


    //help Vector3_Dot
    public Transform otherdot;



    //help Vector3.Lerp  
    // Transforms to act as start and end markers for the journey.
    public Transform startMarker;
    public Transform endMarker;

    // Movement speed in units per second.
    public float speed_on_Vector3_Lerp  = 1.0F;

    // Time when the movement started.
    private float startTime_Vector3_Lerp;

    // Total distance between the markers.
    private float journeyLength_Vector3_Lerp;



    //help Vector3_Max

    public Vector3 a_Vector3_Max = new Vector3(1, 2, 3);
    public Vector3 b_Vector3_Max = new Vector3(4, 3, 2);


    //help Vector3.Min
    public Vector3 a_Vector_min = new Vector3(1, 2, 3);
    public Vector3 b_Vector_min = new Vector3(4, 3, 2);



    //help Vector3_MoveTowards
    // Adjust the speed for the application.
    public float speed_Vector3_MoveTowards = 1.0f;
    // The target (cylinder) position.
    private Transform target_Vector3_MoveTowards;



    //help Vector3_OrthoNormalize
    // The axis and amount of scaling.
    public Vector3 stretchAxis_Vector3_OrthoNormalize;
    public float stretchFactor_Vector3_OrthoNormalize = 1.0F;

    // MeshFilter component and arrays for the original and transformed vertices.
    private MeshFilter mf_Vector3_OrthoNormalize;
    private Vector3[] origVerts_Vector3_OrthoNormalize;
    private Vector3[] newVerts_Vector3_OrthoNormalize;

    // Our new basis vectors.
    private Vector3 basisA_Vector3_OrthoNormalize;
    private Vector3 basisB_Vector3_OrthoNormalize;
    private Vector3 basisC_Vector3_OrthoNormalize;



    //help Vector3_ProjectOnPlane
    private Vector3 vector, planeNormal;
    private Vector3 response;
    private float radians;
    private float degrees;
    private float timer = 12345.0f;



    //help Vector3_Reflect
    public Transform originalObject_Vector3_Reflect;
    public Transform reflectedObject_Vector3_Reflect;

    //help Vector3_RotateTowards
    // The target marker.
    public Transform target_Vector3_RotateTowards;
    // Angular speed in radians per sec.
    public float speed_Vector3_RotateTowards = 1.0f;




    //help Vector3_SignedAngle
    public Transform target_Vector3_SignedAngle;


    //help Vector3_Slerp
    public Transform sunrise_Vector3_Slerp;
    public Transform sunset_Vector3_Slerp;
    // Time to move from sunrise to sunset position, in seconds.
    public float journeyTime_Vector3_Slerp = 1.0f;
    // The time at which the animation started.
    private float startTime_Vector3_Slerp;



    //help Vector3_SmoothDamp
    public Transform target_Vector3_SmoothDamp;
    public float smoothTime_Vector3_SmoothDamp = 0.3F;
    private Vector3 velocity_Vector3_SmoothDamp = Vector3.zero;


    void Awake()
    {

        if(test_Vector_3 == Test_vector_3.Vector3_MoveTowards)
        {
            awake_Vector3_MoveTowards();
        }
    


    }

    void awake_Vector3_MoveTowards()
    {


        // Position the cube at the origin.
        transform.position = new Vector3(0.0f, 0.0f, 0.0f);

        // Create and position the cylinder. Reduce the size.
        var cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.localScale = new Vector3(0.15f, 1.0f, 0.15f);

        // Grab cylinder values and place on the target.
        target_Vector3_MoveTowards = cylinder.transform;
        target_Vector3_MoveTowards.transform.position = new Vector3(0.8f, 0.0f, 0.8f);

        // Position the camera.
        Camera.main.transform.position = new Vector3(0.85f, 1.0f, -3.0f);
        Camera.main.transform.localEulerAngles = new Vector3(15.0f, -20.0f, -0.5f);

        // Create and position the floor.
        GameObject floor = GameObject.CreatePrimitive(PrimitiveType.Plane);
        floor.transform.position = new Vector3(0.0f, -1.0f, 0.0f);



    }


    private void Start()
    {

        Example_vector3();


        //help Vector3_consturcter
        //Set the vector, which you use to move the RigidBody upwards straight away
        myVector = new Vector3(0.0f, 1.0f, 0.0f);
        //Fetch the RigidBody you attach to the GameObject
        m_Rigidbody = GetComponent<Rigidbody>();



        //help Vector3.Lerp 
        // Keep a note of the time the movement started.
        startTime_Vector3_Lerp = Time.time;

        // Calculate the journey length.
        journeyLength_Vector3_Lerp = Vector3.Distance(startMarker.position, endMarker.position);




        //help Vector3_OrthoNormalize
        // Get the Mesh Filter, then make a copy of the original vertices
        // and a new array to calculate the transformed vertices.
        mf_Vector3_OrthoNormalize = GetComponent<MeshFilter>();
        origVerts_Vector3_OrthoNormalize = mf_Vector3_OrthoNormalize.mesh.vertices;
        newVerts_Vector3_OrthoNormalize = new Vector3[origVerts_Vector3_OrthoNormalize.Length];




        // Note the time at the start of the animation.
        startTime_Vector3_Slerp = Time.time;


    }

    void Example_vector3()
    {
        if (test_Vector_3 == Test_vector_3.Vector3_back)
        {
            Vector3_back();
        }
        else if(test_Vector_3 == Test_vector_3.Vector3_down)
        {
            Vector3_down();
        }
        else if( test_Vector_3 == Test_vector_3.Vector3_foward)
        {
            Vector3_forward();
        }
        else if( test_Vector_3 == Test_vector_3.Vector3_left)
        {

        }
        
    }


    public void Vector3_back()
    {
        transform.position += Vector3.back * Time.deltaTime;


        /*
         Description
        Shorthand for writing Vector3(0, 0, -1).
        */
    }


    public void Vector3_down()
    {

        transform.position += Vector3.down * Time.deltaTime;

        /*
         Description
        Shorthand for writing Vector3(0, -1, 0).
        */
    }

    public void Vector3_forward()
    {
        transform.position += Vector3.forward * Time.deltaTime;

        /*
        Description
       Shorthand for writing Vector3(0, -1, 0).
       */

    }

    public void Vector3_left()
    {
        transform.position += Vector3.left * Time.deltaTime;


        /*
        Description
        Shorthand for writing Vector3(-1, 0, 0).
        */

    }    


    public void Vector3_negativeInfinity()
    {

         /*
            public static Vector3 negativeInfinity;
            Description
            Shorthand for writing Vector3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity).

        */

    }

    public void Vector3_one()
    {
        transform.position = Vector3.one;

        /*
         Description
        Shorthand for writing Vector3(1, 1, 1).
         */

    }


    public void Vector3_positiveInfinity()
    {

        /*
           public static Vector3 positiveInfinity;
          Description
            Shorthand for writing Vector3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity).

       */

    }


    public void Vector3_right()
    {
        transform.position += Vector3.right * Time.deltaTime;

        /*
        public static Vector3 right;
        Description
        Shorthand for writing Vector3(1, 0, 0).
        */
    }


    public void Vector3_up()
    {

        /*
           public static Vector3 up;
           Description
            Shorthand for writing Vector3(0, 1, 0).
         */

        transform.position += Vector3.up * Time.deltaTime;

    }


    public void Vector3_zero()
    {
        transform.position = Vector3.zero;

        /*
            public static Vector3 zero;
            Description
            Shorthand for writing Vector3(0, 0, 0).
        */

    }


    public void Vector3_magnitude()
    {
        /*
            public float magnitude;
            Description
            Returns the length of this vector (Read Only).

            The length of the vector is square root of (x*x+y*y+z*z).

            If you only need to compare magnitudes of some vectors, you can compare squared magnitudes of them using sqrMagnitude (computing squared magnitudes is faster).
          
         */
    }


    public void Vector3_Normalize()
    {

        /*
         Declaration
            public void Normalize();
            Description
            Makes this vector have a magnitude of 1.

            When normalized, a vector keeps the same direction but its length is 1.0.

            Note that this function will change the current vector. If you want to keep the current vector unchanged, use normalized variable.

            If this vector is too small to be normalized it will be set to zero.

            Additional resources: normalized property.


           both of those code solutions are fundamentally different. the first ends up with both vec1 and vec2 being normalized, the other ends up with only vec1 being the normalized value.

            depends on the system you test it on. I tested it on my system and the speed difference between the 2 are actually really close, sometimes a being slightly faster than b, then other times b faster than a, averaging out to very close� if only leaning slightly in the favor of a (Normalize()).

                Rewriting a to be more appropriate and result in the behaviour of b you�d get this:

                vec1 = vec2;
                vec1.Normalize();
                Oddly� on my machine� this performs ever so slightly faster than the other way around.

           Which only serves to show that the speeds are so darn close it�s really hard to say.

            @BlackPete already pointed out the underlying behaviour of �normalized�. But I had ran a test of that as well. And it actually ends up being the fastest of the lot consistently. Which makes sense since it has the fewest method calls, which is where most of the overhead is coming from.

            If you want to get super technical, you could even write your own custom normalize method and speed it up even more. This showed to be the fastest of them all (since we minimized method calls to a minimum):


             public static Vector3 CustomNormalize(Vector3 v)
            {
            double m = System.Math.Sqrt(v.x * v.x + v.y * v.y + v.z * v.z);
            if (m > 9.99999974737875E-06)
            {
                float fm = (float)m;
                v.x /= fm;
                v.y /= fm;
                v.z /= fm;
                return v;
            }
            else
                return Vector3.zero;
            }  


        As said and as the name suggests a Vector3 has 3 components x, y, z.

        If you are only interested in x and y you should rather use a Vector2 and normalize that one:

        var shootDirection = (mousePosition - (Vector2)shootpoint.transform.position). normalized;


        */

        /*
         it's help to computer vector a and vector b to move will corrent 
        dlc:  https://www.wayline.io/blog/unity-how-to-normalize-a-vector
         */
    }

    public void Vector3_sqrMagnitude()
    {

        /*
         public float sqrMagnitude;
        Description
            Returns the squared length of this vector (Read Only).

T               he magnitude of a vector v is calculated as Mathf.Sqrt(Vector3.Dot(v, v)). However, 
        the Sqrt calculation is quite complicated and takes longer to execute than the normal arithmetic operations.
        Calculating the squared magnitude instead of using the magnitude property is much faster - the calculation is basically the same only without the slow Sqrt call. 
        If you are using magnitudes simply to compare distances,
        then you can just as well compare squared magnitudes against the squares of distances since the comparison will give the same result.
          
        */


        // detects when the other transform is closer than closeDistance
        // this is faster than using Vector3.magnitude


        if (other_sqrMagnitude)
        {
            Vector3 offset = other_sqrMagnitude.position - transform.position;
            float sqrLen = offset.sqrMagnitude;

            // square the distance we compare with
            if (sqrLen < closeDistance * closeDistance)
            {
                print("The other transform is close to me!");
            }
        }

    }


    public void Vector3_this_int_()
    {
        /*
          
         public float this[int];
            Description
            Access the x, y, z components using [0], [1], [2] respectively. 
         
        */
        // set p.y as 5.0f
        p[1] = 5.0f;

        transform.position += p * Time.deltaTime;



        

    }


    public void Vector3_consturcter()
    {

        //Move the RigidBody upwards at the speed you define
        //m_Rigidbody.linearVelocity = myVector * m_Speed;

        //Move the RigidBody upwards at the speed you define
        m_Rigidbody.linearVelocity = myVector * m_Speed;
    }


    public void Vector3_Angle()
    {

        /*
        Declaration
        public static float Angle(Vector3 from, Vector3 to);
        Parameters
        Parameter	Description
            from	The vector from which the angular difference is measured.
            to	The vector to which the angular difference is measured.
        Returns
        float The angle in degrees between the two vectors.

        Description
            Calculates the angle between two vectors.

            The angle returned is the angle of rotation from the first vector to the second, when treating these two vector inputs as directions.
        Note: The angle returned will always be between 0 and 180 degrees, because the method returns the smallest angle between the vectors. 
        That is, it will never return a reflex angle.

        */

        Vector3 targetDir = target_Vector3_Angle.position - transform.position;
        float angle = Vector3.Angle(targetDir, transform.forward);

        if (angle < 5.0f)
            print("Close");



    }


    public void Vector3_ClampMagnitude()
    {

        /*

        Declaration
        public static Vector3 ClampMagnitude(Vector3 vector, float maxLength);
        Description
        Returns a copy of vector with its magnitude clamped to maxLength.

        */

        // Get the new position for the object.
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 newPos = transform.position + movement;

        // Calculate the distance of the new position from the center point. Keep the direction
        // the same but clamp the length to the specified radius.
        Vector3 offset = newPos - centerPt;
        transform.position = centerPt + Vector3.ClampMagnitude(offset, radius);


    }


    public void Vector3_Cross()
    {

        /*   
        Declaration
        public static Vector3 Cross(Vector3 lhs, Vector3 rhs);

        Description
        Cross Product of two vectors.

        The cross product of two vectors results in a third vector which is perpendicular to the two input vectors. 
        The result's magnitude is equal to the magnitudes of the two inputs multiplied together and then multiplied by the sine of the angle between the inputs. 
        You can determine the direction of the result vector using the "left hand rule".
         */


        // Get the normal to a triangle from the three corner points a, b, and o, where o is the origin point of vectors a and b.
        Vector3 GetNormal(Vector3 a, Vector3 b, Vector3 o)
        {
            // Find vectors corresponding to two of the sides of the triangle.
            Vector3 side1 = a - o;
            Vector3 side2 = b - o;

            // Cross the vectors to get a perpendicular vector, then normalize it. This is the Result vector in the drawing above.
            return Vector3.Cross(side1, side2).normalized;
        }


    }


    public void Vector3_Distance()
    {

        /*
         Declaration
        public static float Distance(Vector3 a, Vector3 b);
        Description
        Returns the distance between a and b.

        Vector3.Distance(a,b) is the same as (a-b).magnitude. 
         
        */

        if (otherDistance)
        {
            float dist = Vector3.Distance(otherDistance.position, transform.position);
            print("Distance to other: " + dist);
        }



    }

    public void Vector3_Dot()
    {
        // detects if other transform is behind this object


        if (otherdot)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Vector3 toOther = Vector3.Normalize(otherdot.position - transform.position);

            if (Vector3.Dot(forward, toOther) < 0)
            {
                print("The other transform is behind me!");
            }
        }


    }


    public void Vector3_Lerp()
    {

        /*

        Declaration
        public static Vector3 Lerp(Vector3 a, Vector3 b, float t);
        Parameters
        Parameter	Description
        a	Start value, returned when t = 0.
        b	End value, returned when t = 1.
        t	Value used to interpolate between a and b.
        Returns
        Vector3 Interpolated value, equals to a + (b - a) * t.

        Description
        Linearly interpolates between two points.

        Interpolates between the points a and b by the interpolant t. The parameter t is clamped to the range [0, 1]. This is most commonly used to find a point some fraction of the way along a line between two endpoints (e.g. to move an object gradually between those points).

        The value returned equals a + (b - a) * t (which can also be written a * (1-t) + b*t).
        When t = 0, Vector3.Lerp(a, b, t) returns a.
        When t = 1, Vector3.Lerp(a, b, t) returns b.
        When t = 0.5, Vector3.Lerp(a, b, t) returns the point midway between a and b.

        */


        // A longer example of Vector3.Lerp usage.
        // Drop this script under an object in your scene, and specify 2 other objects in the "startMarker"/"endMarker" variables in the script inspector window.
        // At play time, the script will move the object along a path between the position of those two markers.


        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime_Vector3_Lerp) * speed_on_Vector3_Lerp;

        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength_Vector3_Lerp;

        // Set our position as a fraction of the distance between the markers.
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fractionOfJourney);


    }


    public void Vector3_LerpUnclamped()
    {


        /*
        Declaration
        public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t);
        Description
        Linearly interpolates between two vectors.

        Interpolates between the vectors a and b by the interpolant t. 
        This is most commonly used to find a point some fraction of the way along a line between two endpoints (e.g. to move an object gradually between those points).

        When t = 0 returns a. When t = 1 returns b. When t = 0.5 returns the point midway between a and b.

        Additional resources: Lerp.


         */

    }


    public void Vector3_Max()
    {

        print(Vector3.Max(a_Vector3_Max, b_Vector3_Max)); // prints (4.0f, 3.0f, 3.0f)

    }


    public void Vector3_Min()
    {

        //print(Vector3.Min(a, b));     // prints (1.0f, 2.0f, 2.0f)
        print(Vector3.Min(a_Vector_min, b_Vector_min));     // prints (1.0f, 2.0f, 2.0f)
    }


    public void Vector3_MoveTowards()
    {

        /*
        Declaration
        public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta);
        Parameters
        Parameter	Description
        current	The position to move from.
        target	The position to move towards.
        maxDistanceDelta	Distance to move current per call.
        Returns
        Vector3 The new position.

        Description
        Calculate a position between the points specified by current and target, moving no farther than the distance specified by maxDistanceDelta.

        Use the MoveTowards member to move an object at the current position toward the target position. By updating an object’s position each frame using the position calculated by this function, you can move it towards the target smoothly. Control the speed of movement with the maxDistanceDelta parameter. If the current position is already closer to the target than maxDistanceDelta, the value returned is equal to target; the new position does not overshoot target. To make sure that object speed is independent of frame rate, multiply the maxDistanceDelta value by Time.deltaTime (or Time.fixedDeltaTime in a FixedUpdate loop).

        Note that if you set maxDistanceDelta to a negative value, this function returns a position in the opposite direction from the target.
         */

        // Vector3.MoveTowards example.

        // A cube can be moved around the world. It is kept inside a 1 unit by 1 unit
        // xz space. A small, long cylinder is created and positioned away from the center of
        // the 1x1 unit. The cylinder is moved between two locations. Each time the cylinder is
        // positioned the cube moves towards it. When the cube reaches the cylinder the cylinder
        // is re-positioned to the other location. The cube then changes direction and moves
        // towards the cylinder again.
        //
        // A floor object is created for you.
        //
        // To view this example, create a new 3d Project and create a Cube placed at
        // the origin. Create Example.cs and change the script code to that shown below.
        // Save the script and add to the Cube.
        //
        // Now run the example.



        // Move our position a step closer to the target.
        var step = speed_Vector3_MoveTowards * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, target_Vector3_MoveTowards.position, step);

        // Check if the position of the cube and sphere are approximately equal.
        if (Vector3.Distance(transform.position, target_Vector3_MoveTowards.position) < 0.001f)
        {
            // Swap the position of the cylinder.
            target_Vector3_MoveTowards.position *= -1.0f;
        }


    }

    public void Vector3_Normalize_void()
    {
        /*
        Declaration
        public void Normalize();
        Description
        Makes this vector have a magnitude of 1.

        When normalized, a vector keeps the same direction but its length is 1.0.

        Note that this function will change the current vector. 
        If you want to keep the current vector unchanged, use normalized variable.

        If this vector is too small to be normalized it will be set to zero.

        Additional resources: normalized property.

        Declaration
        public static Vector3 Normalize(Vector3 value);
        Parameters
        Parameter	Description
        value	The vector to be normalized.
        Returns
        Vector3 A new vector with the same direction as the original vector but with a magnitude of 1.0.

        Description
        Returns a normalized vector based on the given vector. 
        The normalized vector has a magnitude of 1 and is in the same direction as the given vector. 
        Returns a zero vector If the given vector is too small to be normalized.

        Note that this does not modify the given vector. 
        To modify and normalize the current vector, 
        use the Normalize function without a parameter.

        Additional resources: normalized function.

        */

        /*
        I think if you know what normalizing is, it should be self-explanatory.
        And if you don’t, you shouldn’t be using the function. Where exactly is your knowledge incomplete?
        */


        Debug.Log(new Vector3(0, 2, 0).normalized); 	// same as Vector3.up.  (0,1,0)

    }


    public void Vector3_OrthoNormalize()
    {

        /*
         
        Declaration
        public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent);
        Description
        Makes vectors normalized and orthogonal to each other.

        Normalizes normal. 
        Normalizes tangent and makes sure it is orthogonal to normal (that is, angle between them is 90 degrees).

        Additional resources: Normalize function.

        Declaration
        public static void OrthoNormalize(ref Vector3 normal, 
        ref Vector3 tangent, ref Vector3 binormal);
        Description
        Makes vectors normalized and orthogonal to each other.

        Normalizes normal.
        Normalizes tangent and makes sure it is orthogonal to normal. 
        Normalizes binormal and makes sure it is orthogonal to both normal and tangent.

        Points in space are usually specified with coordinates in the standard XYZ axis system. However, 
        you can interpret any three vectors as "axes" if they are normalized (ie, have a magnitude of 1) 
        and are orthogonal (ie, perpendicular to each other).

        Creating your own coordinate axes is useful, 
        say, if you want to scale a mesh in arbitrary directions rather than just along the XYZ axes - you can transform the vertices to your own coordinate system, 
        scale them and then transform back.
        Often, a transformation like this will be carried out along only one axis while the other two are either left as they are or treated equally.
        For example, a stretching effect can be applied to a mesh by scaling up on one axis while scaling down proportionally on the other two. T
        his means that once the first axis vector is specified, it doesn't greatly matter what the other two are as long as they are normalized and orthogonal. 
        OrthoNormalize can be used to ensure the first vector is normal and then generate two normalized, orthogonal vectors for the other two axes.
          
        */


        // BasisA is just the specified axis for stretching - the
        // other two are just arbitrary axes generated by OrthoNormalize.
        basisA_Vector3_OrthoNormalize = stretchAxis_Vector3_OrthoNormalize;
        Vector3.OrthoNormalize(ref basisA_Vector3_OrthoNormalize, ref basisB_Vector3_OrthoNormalize, ref basisC_Vector3_OrthoNormalize);

        // Copy the three new basis vectors into the rows of a matrix
        // (since it is actually a 4x4 matrix, the bottom right corner
        // should also be set to 1).
        Matrix4x4 toNewSpace = new Matrix4x4();
        toNewSpace.SetRow(0, basisA_Vector3_OrthoNormalize);
        toNewSpace.SetRow(1, basisB_Vector3_OrthoNormalize);
        toNewSpace.SetRow(2, basisC_Vector3_OrthoNormalize);
        toNewSpace[3, 3] = 1.0F;

        // The scale values are just the diagonal entries of the scale
        // matrix. The vertices should be stretched along the first axis
        // and squashed proportionally along the other two.
        Matrix4x4 scale = new Matrix4x4();
        scale[0, 0] = stretchFactor_Vector3_OrthoNormalize;
        scale[1, 1] = 1.0F / stretchFactor_Vector3_OrthoNormalize;
        scale[2, 2] = 1.0F / stretchFactor_Vector3_OrthoNormalize;
        scale[3, 3] = 1.0F;

        // The inverse of the first matrix transforms the vertices back to
        // the original XYZ coordinate space(transpose is the same as inverse
        // for an orthogonal matrix, which this is).
        Matrix4x4 fromNewSpace = toNewSpace.transpose;

        // The three matrices can now be combined into a single symmetric matrix.
        Matrix4x4 trans = toNewSpace * scale * fromNewSpace;

        // Transform each of the mesh's vertices by the symmetric matrix.
        int i = 0;
        while (i < origVerts_Vector3_OrthoNormalize.Length)
        {
            newVerts_Vector3_OrthoNormalize[i] = trans.MultiplyPoint3x4(origVerts_Vector3_OrthoNormalize[i]);
            i++;
        }

        // ...and finally, update the mesh with the new vertex array.
        mf_Vector3_OrthoNormalize.mesh.vertices = newVerts_Vector3_OrthoNormalize;


    }

    public void Vector3_Project(Transform target, Vector3 railDirection)
    {

        /*
         
        Declaration
        public static Vector3 Project(Vector3 vector, Vector3 onNormal);
        Description
        Projects a vector onto another vector.

        To understand vector projection, imagine that onNormal is resting on a line pointing in its direction. 
        Somewhere along that line will be the nearest point to the tip of vector. 
        The projection is just onNormal rescaled so that it reaches that point on the line.



        The function will return a zero vector if onNormal is almost zero.

        An example of the usage of projection is a rail-mounted gun that should slide so that it gets as close as possible to a target object.
        The projection of the target heading along the direction of the rail can be used to move the gun by applying a force to a rigidbody, say.


         */


        Vector3 heading = target.position - transform.position;
        Vector3 force = Vector3.Project(heading, railDirection);

        GetComponent<Rigidbody>().AddForce(force);


    }

    public void Vector3_ProjectOnPlane()
    {
        /*
          
         // Vector3.ProjectOnPlane - example

        // Generate a random plane in xy. Show the position of a random
        // vector and a connection to the plane. The example shows nothing
        // in the Game view but uses Update(). The script reference example
        // uses Gizmos to show the positions and axes in the Scene.
         
        */

        /*
         
        Declaration
        public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal);
        Parameters
        Parameter	Description
        vector	The vector to project on the plane.
        planeNormal	The normal which defines the plane to project on.
        Returns
        Vector3 The orthogonal projection of vector on the plane.

        Description
        Projects a vector onto a plane.

        For a given plane described by planeNormal and a given vector vector, 
        Vector3.ProjectOnPlane generates a new vector orthogonal to planeNormal and parallel to the plane. 
        Note: planeNormal does not need to be normalized.

          
         */


        if (timer > 2.0f)
        {
            // Generate a position inside xy space.
            vector = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0.0f);

            // Compute a normal from the plane through the origin.
            degrees = Random.Range(-45.0f, 45.0f);
            radians = degrees * Mathf.Deg2Rad;
            planeNormal = new Vector3(Mathf.Cos(radians), Mathf.Sin(radians), 0.0f);

            // Obtain the ProjectOnPlane result.
            response = Vector3.ProjectOnPlane(vector, planeNormal);

            // Reset the timer.
            timer = 0.0f;
        }
        timer += Time.deltaTime;


    }



    // Show a Scene view example.
    void OnDrawGizmosSelected_Vector3_ProjectOnPlane()
    {
        // Left/right and up/down axes.
        Gizmos.color = Color.white;
        Gizmos.DrawLine(transform.position - new Vector3(2.25f, 0, 0), transform.position + new Vector3(2.25f, 0, 0));
        Gizmos.DrawLine(transform.position - new Vector3(0, 1.75f, 0), transform.position + new Vector3(0, 1.75f, 0));

        // Display the plane.
        Gizmos.color = Color.green;
        Vector3 angle = new Vector3(-1.75f * Mathf.Sin(radians), 1.75f * Mathf.Cos(radians), 0.0f);
        Gizmos.DrawLine(transform.position - angle, transform.position + angle);

        // Show the projection on the plane as a blue line.
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, response);
        Gizmos.DrawSphere(response, 0.05f);

        // Show the vector perpendicular to the plane in yellow
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(vector, response);

        // Now show the input position.
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(vector, 0.05f);
        Gizmos.DrawLine(Vector3.zero, vector);
    }


    public void Vector3_Reflect()
    {

        /*      
        Declaration
        public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal);
        Parameters
        Parameter	Description
        inDirection	The direction vector towards the plane.
        inNormal	The normal vector that defines the plane.
        Description
        Reflects a vector off the plane defined by a normal.

        This method calculates the reflection vector using the following formula: v = inDirection - 2 * inNormal * dot(inDirection inNormal). 
        The inNormal vector defines a plane. A plane's normal is the vector that is perpendicular to its surface.
        The inDirection vector is treated as a directional arrow coming into the plane.
        The returned value is a vector of equal magnitude to inDirection but with its direction reflected.


        Reflection of a vector off a plane.
        */

        // Makes the reflected object appear opposite of the original object,
        // mirrored along the z-axis of the world
        reflectedObject_Vector3_Reflect.position = Vector3.Reflect(originalObject_Vector3_Reflect.position, Vector3.right);


    }


    public void Vector3_RotateTowards()
    {

        /*
         Declaration
            public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta);
            Parameters
            Parameter	Description
        current	The vector being managed.
        target	The vector.
        maxRadiansDelta	The maximum angle in radians allowed for this rotation.
        maxMagnitudeDelta	The maximum allowed change in vector magnitude for this rotation.
        Returns
        Vector3 The location that RotateTowards generates.

        Description
        Rotates a vector current towards target.

        This function is similar to MoveTowards except that the vector is treated as a direction rather than a position. 
        The current vector will be rotated round toward the target direction by an angle of maxRadiansDelta, 
        although it will land exactly on the target rather than overshoot. If the magnitudes of current and target are different, 
        then the magnitude of the result will be linearly interpolated during the rotation. If a negative value is used for maxRadiansDelta, 
        the vector will rotate away from target/ until it is pointing in exactly the opposite direction, then stops.


        Additional resources: Quaternion.RotateTowards.
         */


        /*
         * // To use this script, attach it to the GameObject that you would like to rotate towards another game object.
            // After attaching it, go to the inspector and drag the GameObject you would like to rotate towards into the target field.
            // Move the target around in the scene view to see the GameObject continuously rotate towards it.
        */


        // Determine which direction to rotate towards
        Vector3 targetDirection = target_Vector3_RotateTowards.position - transform.position;

        // The step size is equal to speed times frame time.
        float singleStep = speed_Vector3_RotateTowards * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // Draw a ray pointing at our target in
        Debug.DrawRay(transform.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and applies rotation to this object

        transform.rotation = Quaternion.LookRotation(newDirection);
    }

    public void Vector3_Scale()
    {

        /*    
        Declaration
        public static Vector3 Scale(Vector3 a, Vector3 b);
        Description
        Multiplies two vectors component-wise.

        Every component in the result is a component of a multiplied by the same component of b.
        */

        // Calculate the two vectors generating a result.
        // This will compute Vector3(2, 6, 12)
        print(Vector3.Scale(new Vector3(1, 2, 3), new Vector3(2, 3, 4)));

    }


    public void Vector3_SignedAngle()
    {

        /*
         
        Declaration
        public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis);
        Parameters
        Parameter	Description
        from	The vector from which the angular difference is measured.
        to	The vector to which the angular difference is measured.
        axis	A vector around which the other vectors are rotated.
        Returns
        float Returns the signed angle between from and to in degrees.

        Description
        Calculates the signed angle between vectors from and to in relation to axis.

        The angle returned is the angle of rotation from the first vector to the second, when treating these first two vector inputs as directions. 
        These two vectors also define the plane of rotation, 
        meaning they are parallel to the plane. 
        This means the axis of rotation around which the angle is calculated is the cross product of the first and second vectors (and not the 3rd "axis" parameter).
        You can use the "left hand rule" to determine the axis of rotation, given the two input vectors. 
        The third input (named the “axis” parameter), gives you a way to provide a contextual direction to include in the calculation. 
        This has the result of flipping the sign of the result depending on whether 
        this third vector that you supply falls above or below the plane of rotation defined by the first two input vectors. 
        Therefore the sign of the final result depends 
        on two things: the order in which you supply the "from" and "to" vector, and the direction of the third "axis" vector.
        Note: The angle returned will always be between -180 and 180 degrees, because the method returns the smallest angle between the vectors. 
        That is, it will never return a reflex angle.
         
         */

        Vector3 targetDir = target_Vector3_SignedAngle.position - transform.position;
        Vector3 forward = transform.forward;
        float angle = Vector3.SignedAngle(targetDir, forward, Vector3.up);
        if (angle < -5.0F)
            print("turn right");
        else if (angle > 5.0F)
            print("turn left");
        else
            print("forward");


    }



    public void Vector3_Slerp()
    {
        /*
         
        Declaration
        public static Vector3 Slerp(Vector3 a, Vector3 b, float t);
        Description
        Spherically interpolates between two vectors.

        Interpolates between a and b by amount t. 
        The difference between this and linear interpolation (aka, "lerp") is that the vectors are treated as directions rather than points in space. 
        The direction of the returned vector is interpolated by the angle and its magnitude is interpolated between the magnitudes of from and to.

        The parameter t is clamped to the range [0, 1].
         
        */

        // The center of the arc
        Vector3 center = (sunrise_Vector3_Slerp.position + sunset_Vector3_Slerp.position) * 0.5F;

        // move the center a bit downwards to make the arc vertical
        center -= new Vector3(0, 1, 0);

        // Interpolate over the arc relative to center
        Vector3 riseRelCenter = sunrise_Vector3_Slerp.position - center;
        Vector3 setRelCenter = sunset_Vector3_Slerp.position - center;

        // The fraction of the animation that has happened so far is
        // equal to the elapsed time divided by the desired time for
        // the total journey.
        float fracComplete = (Time.time - startTime_Vector3_Slerp) / journeyTime_Vector3_Slerp;

        transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
        transform.position += center;


    }



    public void Vector3_SlerpUnclamped()
    {

        /*
        Declaration
        public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t);
        Description
        Spherically interpolates between two vectors.

        Interpolates between a and b by amount t. 
        The difference between this and linear interpolation (aka, "lerp") is that the vectors are treated as directions rather than points in space. 
        The direction of the returned vector is interpolated by the angle and its magnitude is interpolated between the magnitudes of from and to.

        Note: This static method can slerp beyond the a and b vectors. This means t can be less than zero or greater than one.

        Additional resources: Slerp.         
        */

    }


    public void Vector3_SmoothDamp()
    {

        /*
         
        Declaration
        public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed = Mathf.Infinity, float deltaTime = Time.deltaTime);
        Parameters
        Parameter	Description
        current	The current position.
        target	The position we are trying to reach.
        currentVelocity	The current velocity, this value is modified by the function every time you call it.
        smoothTime	Approximately the time it will take to reach the target. A smaller value will reach the target faster.
        maxSpeed	Optionally allows you to clamp the maximum speed.
        deltaTime	The time since the last call to this function. By default Time.deltaTime.
        Description
        Gradually changes a vector towards a desired goal over time.

        The vector is smoothed by some spring-damper like function, 
        which will never overshoot. The most common use is for smoothing a follow camera.
          
         
         */


        // Smooth towards the target

        // Define a target position above and behind the target transform
        Vector3 targetPosition = target_Vector3_SmoothDamp.TransformPoint(new Vector3(0, 5, -10));

        // Smoothly move the camera towards that target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity_Vector3_SmoothDamp, smoothTime_Vector3_SmoothDamp);



    }


    void Update()
    {

        if(test_Vector_3 == Test_vector_3.Vector3_sqrMagnitude)
        {
            Vector3_sqrMagnitude();

        }
       
       else  if(test_Vector_3 == Test_vector_3.Vector3_consturcter)
        {
            Vector3_consturcter();
        }    

        else if(test_Vector_3 == Test_vector_3.Vector3_Angle)
        {
            Vector3_Angle();
        }


        else if(test_Vector_3 == Test_vector_3.Vector3_Vector3_ClampMagnitude)
        {
            Vector3_ClampMagnitude();
        }

        else if(test_Vector_3 == Test_vector_3.Vector3_Cross)
        {
            Vector3_Cross();
        }


        else if(test_Vector_3 == Test_vector_3.Vector3_Distance)
        {
            Vector3_Distance();
        }

        else if(test_Vector_3 == Test_vector_3.Vector3_Dot)
        {
            Vector3_Dot();
        }

        else if(test_Vector_3 == Test_vector_3.Vector3_Lerp)
        {
            Vector3_Lerp();
        }
            
        else if(test_Vector_3 == Test_vector_3.Vector3_LerpUnclamped)
        {
            Vector3_LerpUnclamped();
        }

        else if(test_Vector_3 == Test_vector_3.Vector3_Max )
        {

            Vector3_Max();


        }


        else if(test_Vector_3 == Test_vector_3.Vector3_Min)
        {

            Vector3_Min();

        }

        else if(test_Vector_3 == Test_vector_3.Vector3_MoveTowards)
        {

            Vector3_MoveTowards();
        }
        else if(test_Vector_3 == Test_vector_3.Vector3_Normalize_void)
        {

            Vector3_Normalize_void();
        }    


        else if( test_Vector_3 == Test_vector_3.Vector3_Vector3_OrthoNormalize)
        {

            Vector3_OrthoNormalize();

        }

        else if(test_Vector_3 == Test_vector_3.Vector3_ProjectOnPlane)
        {

            Vector3_ProjectOnPlane();
            OnDrawGizmosSelected_Vector3_ProjectOnPlane();
        }

        else if(test_Vector_3 == Test_vector_3.Vector3_Reflect)
        {
            Vector3_Reflect();
        }
      
        else if(test_Vector_3 == Test_vector_3.Vector3_RotateTowards)
        {
            Vector3_RotateTowards();

        }


        else if(test_Vector_3 == Test_vector_3.Vector3_Scale)
        {
            Vector3_Scale();
        }


        else if(test_Vector_3 == Test_vector_3.Vector3_SignedAngle)
        {

            Vector3_SignedAngle();

        }


        else if( test_Vector_3 == Test_vector_3.Vector3_Slerp)
        {

            Vector3_Slerp();

        }

        else if(test_Vector_3 == Test_vector_3.Vector3_SlerpUnclamped)
        {

            Vector3_SlerpUnclamped();

        }



        else if(test_Vector_3 == Test_vector_3.Vector3_SmoothDamp)
        {

            Vector3_SmoothDamp();
            
        }






    }


}
