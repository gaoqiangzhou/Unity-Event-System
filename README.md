
# Unity-Event-System
## Description
A Unity Event System implements the Broadcast Pattern.

In this system
- Each game event is a `GameEvent` scriptable object.
- Boradcaster communicate with receiver through `GameEvent` scriptable object.
#### GameEvent Scriptable object
At runtime, a certain type of `GameEvent`: 
- is a field in the Broadcaster script, and will reference to a list of listeners.
- is a field in the `GameEventListener` script that is attached to a receiver game object. Will register the component as a listener and the corresponding eventhandler.
- When a action that will raise the event is executed in Broadcast, all registered listener in the `GameEvent` scriptable object will get notified and handle the event.

#### GameEventListener.cs 
- A script attahc to a game object that will repond to a certain type of event
- Has a field reference to `GameEvent` SO. e.g. updateHealthEvent.
- Has a field reference to responses to the event.
