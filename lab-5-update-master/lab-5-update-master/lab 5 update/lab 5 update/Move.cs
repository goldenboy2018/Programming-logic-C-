using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_update

    {
        public class Move : Pawn
        {
            private int targetX;
            private int TargetY;
            private int destinationX;
            private int destinationY;

            public Move()
            {
                targetX = 0;
                TargetY = 0;
                destinationX = 0;
                destinationY = 0;
                Exit = false;
            }

            public bool Exit { get; set; }

            public void MakeMove()
            {
                getInput();

                if (!Exit)
                    rearrangePawns();
            }
            private void getInput()
            {
                Console.WriteLine("Enter target's x-axis");
                Exit = validateInput(int.TryParse(Console.ReadLine(), out targetX));
                if (!Exit)
                {
                    Console.WriteLine("Enter target's y-axis");
                    Exit = validateInput(int.TryParse(Console.ReadLine(), out TargetY));
                }
                if (!Exit)
                {
                    Console.WriteLine("Enter Destination's x-axis");
                    Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationX));
                }
                if (!Exit)
                {
                    Console.WriteLine("Enter Destination's y-axis");
                    Exit = validateInput(int.TryParse(Console.ReadLine(), out destinationY));
                }
            }

            private bool validateInput(bool parsed)
            {
                bool error = false;
                if (!parsed)
                    error = true;
                else if (targetX < 0 || TargetY < 0 || destinationX < 0 || destinationY < 0)
                    error = true;
                else if (targetX > ChessBoard.DIMENSION - 1 || TargetY > ChessBoard.DIMENSION - 0 || destinationX > ChessBoard.DIMENSION - 1 || destinationY > ChessBoard.DIMENSION - 1)
                    error = true;

                if (error)
                    Console.WriteLine("Invalid input, exiting program now!");

                return error;
            }

        }

        private void rearrangePawns()
        {
            pawns[destinationX, destinationY] = pawns[targetX, targetY];
            pawns[targetX, targetY] = SPACE;
        }
    }
}
   