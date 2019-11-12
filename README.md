# Unity Submarine
This is a Unity3D project of a submarine moving within an enclosed lake with fish.

The scene consists of a submarine model in Unity, which contains a perspective camera. The submarine can be steered using the keys w (forward),a (left), s (backward) and d (right). Moreover, it has a front light. Another light, representing the sun, has been inserted. It is possible to gradually modify the direction of the sun with the + and − keys.  In addition, it is possible to modify the intensity of the sun with the keys i and j.
There are two camera modes:  submarine camera view (perspective) and an orthographic top view of the entire lake. It is possible to switch camera mode with the buttons 1 (submarine view) and 2 (top view). 
It is also possible to modify the field of view of the perspective camera with the f and v buttons.

The scene contains multiple fish, with different textures, and an irregular terrain, that should reproduce an imaginary seabed.
When multiple objects collide, they change their behaviour. In particular, the terrain doesn't move, while the other obstacles and the submarine do. In case the impact is strong, there is the possibility that an object exists from the water. In that situation, gravity is activited while the object is outside of the water. Gravity is not activated when the object is inside the water, since the modelled objects are not supposed to sink in the real world.
