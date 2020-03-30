# MadBox Test

## The time it took you to perform the exercise
It took me 4:30h to implement the basic loop expeirence and 30min to write the readme and explain some code.

## The parts that were difficult for you and why
One of the most dificult parts was the camera behaviour, in previous projects I'm used to use Cinemachine asset in order to provide a much better camera experience; that was going to be my approach until I read "You should use a simple and readable code that answers in a simple way to the problematics of the exercise." so I asumed that the use of code from third parties (Cinemachine, DOtween...) was forbidden and then I decided to implement a camera movement system based on gameobjects and events. Every time that the player reaches a specific gameobject an event is launched and the camera manager takes care of applying the rotation. Due to the lack of time I was only able to implement rotation without any issue.
In the other hand I had some issues at the beggining in order to decide how to implement the path following. I saw in the original game that the player takes curves very smoothly so I decided that the best approach would be the cubic bezier curve. I had some issues realted to the player movement and its own position. At the end I think that I managed to implement an scalable system free of issues.

## The parts you think you could do better and how
There are a few parts that I think that can be improved. As I said before the camera only moves in the rotation field. I would implement a position transition for the camera.
In terms of code, I think that the GenericObstacle class could be improved in order to make easier the implementation of new types of obstacles whithout having to declare all its properties in its own class.

## What you would do if you could go a step further on this game
I think that one of the coolest features from these kind of games is the ragdoll implementation. I would also add more kinds of obstacles, UI in order to show the path progress and probably some sort of AI in order to make the player compete against it. 

## What did you think
I think that these kind of test are very beneficial to me in terms of programming. The time limitation makes trying to solve everything in the simplest and efficient way possible and I think that that make me improve as a coder.

## Any comment you may have
I hope you enjoy the result. Thank you for the opportunity.
