using System;

namespace AStar {

    public static class PathingConstants {
        public static int StepSize = 1;
        public static readonly StepDirection[] Directions = {

            // Cardinal
            new StepDirection(-StepSize, +0), // W
            new StepDirection(+StepSize, +0), // E
            new StepDirection(+0, +StepSize), // N 
            new StepDirection(+0, -StepSize), // S
            // Diagonal
            new StepDirection(-StepSize, -StepSize), // NW
            new StepDirection(-StepSize, +StepSize), // SW
            new StepDirection(+StepSize, -StepSize), // NE
            new StepDirection(+StepSize, +StepSize)  // SE
        };
    }

}