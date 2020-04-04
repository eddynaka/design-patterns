# Tips
- Strive for loosely coupled designs between objects that interact

# Bullet Points
- The Observer Pattern defines a one-to-many relationship between objects
- Subjects, or as we also know them, Observables, update Observers using a common interface
- Observers are loosely coupled in that the Observable knows nothing about them, other than that they implement the Observer interface
- You can push or pull data from the Observable when using the pattern (pull is considered more "correct")
- Don't depend on a specific order of notification for your Observers
- Java has several implementations of the Observer Pattern, including the general purpose java.util.Observable
- Watch out for issues with the java.util.Observable implementation
- Don't be afraid to create your own Observable implementation if needed
- Swing makes heavy use of the Observer Pattern, as do many GUI frameworks
- You'll also find the pattern in many other places, including JavaBeans and RMI