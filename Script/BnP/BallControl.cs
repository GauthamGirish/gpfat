using UnityEngine;
public class BallControl : MonoBehaviour
{
    public float force = 10f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        // Use arrow keys to apply force in different directions
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * force);
        }
    }
}











































/*
Steps to Create a Unity Project with Sliding Ball Mechanics:

1. Start a New 3D Project
   - Unity starts with a default camera and light.
   - You’ll be adding objects like the ball and a sloped platform for the ball to slide on.

2. Create the Ground/Platform:
   - Right-click in the Hierarchy and choose 3D Object > Plane. This will serve as the ground.
   - Scale and position it as needed (use the Scale Tool or set values like 10, 1, 10 to make it larger).
   - Optionally, create a ramp for the ball to slide down:
     - Use a cube (3D Object > Cube), scale it along the X or Z axis, and rotate it slightly to create an incline.

3. Create the Ball:
   - Right-click in the Hierarchy and choose 3D Object > Sphere. This will be your ball.
   - Position the sphere above the ramp/plane so it can slide down.
   - Scale it to a desired size, like 0.5 for both X, Y, and Z axes.
   - Rename the sphere object to "Ball" for clarity.

4. Add Physics to the Ball:
   - Add a Rigidbody Component:
     - Select the ball (sphere) and click Component > Physics > Rigidbody.
     - The Rigidbody will allow the ball to interact with the physics engine, including gravity, forces, and collisions.
     - Set the mass of the ball to a reasonable value, such as 1, to simulate realistic movement.
   - Add Collider Components:
     - The ball already has a SphereCollider.
     - The ground should have a BoxCollider (Planes come with a BoxCollider by default).

5. Apply Newtonian Mechanics:
   - Newton's First Law (Inertia):
     - The Rigidbody component automatically applies inertia. The ball will stay at rest or continue sliding unless a force (like friction or collision) acts upon it.
   - Newton's Second Law (Force = Mass × Acceleration):
     - Gravity will naturally pull the ball down the inclined plane, causing it to accelerate.
     - By adjusting the slope, you control how fast it moves.
   - Newton's Third Law (Action-Reaction):
     - When the ball hits the ground or other objects, it will react with opposite forces, causing it to bounce or stop, depending on friction and material settings.

6. Adjust Physics Settings:
   - Global Gravity:
     - Unity’s default gravity is set to Earth's gravity (-9.81 m/s² on the Y-axis).
     - You can adjust gravity in the Project Settings: Go to Edit > Project Settings > Physics and change the gravity settings if needed.
   - Friction:
     - To control sliding, adjust the friction on the plane and ball:
       - Create a Physic Material by right-clicking in the Project window and selecting Create > Physic Material.
       - Set the Dynamic Friction and Static Friction properties. Lower values make the ball slide more easily.
       - Assign this physic material to the plane's and ball's colliders to control how easily the ball slides.

7. Implement Sliding Mechanics:
   - Position the Ball:
     - Place the ball at the top of the inclined platform so it will slide down under the influence of gravity.
   - Test:
     - Press Play to test if the ball slides down the ramp. Gravity should naturally pull the ball down the slope due to the Rigidbody component.
   - Adjust Friction and Mass:
     - Adjust the friction values to control how fast or slow the ball slides.
     - Tweak the mass of the ball if needed to simulate different sliding behaviors.
*/
