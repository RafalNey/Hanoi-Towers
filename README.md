# Hanoi-Towers

Written in C# after finishing the "21 days course: Basics of C#" by Adam Kamizelich.

Hanoi Towers is a mathematical game or puzzle consisting of three rods and a number of disks of various diameters, which can slide onto any rod. The puzzle begins with the disks stacked on one rod in order of decreasing size, the smallest at the top, thus approximating a conical shape. The objective of the puzzle is to move the entire stack to one of the other rods, obeying the following rules:

    1. Only one disk may be moved at a time.
    2. Each move consists of taking the upper disk from one of the stacks and placing it on top of another stack or on an empty rod.
    3. No disk may be placed on top of a disk that is smaller than it.

I build this game with three levels of difficulty (easy, normal and hard). Game stores the number of player moves in files. Entire game is in a text mode and looks something like this:

                __                                __                                __
             __|__|__                            |  |                              |  |
            |████████|                           |  |                              |  |
           ____|__|____                          |  |                              |  |
          |████████████|                         |  |                              |  |
         ______|__|______                        |  |                              |  |
        |████████████████|                       |  |                              |  |
       ________|__|________                      |  |                              |  |
      |████████████████████|                     |  |                              |  |
     __________|__|__________                    |  |                              |  |
    |████████████████████████|                   |  |                              |  |

                ██╗                             █████╗                            █████╗
              ████║                             ╚═══██╗                           ╚═══██╗
              ╚═██║                              ████╔╝                            ████╔╝
                ██║                             ██╔══╝                             ╚══██╗
                ██║                             ██████╗                           █████╔╝
                ╚═╝                             ╚═════╝                           ╚════╝

Enjoy the game :-)
