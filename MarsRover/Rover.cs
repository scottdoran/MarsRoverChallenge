using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        public Position CurrentPosition { get; set; }

        public int NoOfScuffs { get; set; }

        public Rover(Position initialPosition)
        {
            CurrentPosition = initialPosition;
        }

        public void ExecuteMovementInstructions(String movementInstructions, Crater crater)
        {
            foreach (Char instruction in movementInstructions)
            {
                switch (instruction)
                {
                    case 'F':
                        MoveForward(crater);
                        break;
                    case 'L':
                        RotateLeft();
                        break;
                    case 'R':
                        RotateRight();
                        break;
                }
                ReportLocationAndDirection();
            }
        }

        private void RotateLeft()
        {
            switch (CurrentPosition.Direction)
            {
                case "N":
                    CurrentPosition.Direction = "W";
                    break;
                case "E":
                    CurrentPosition.Direction = "N";
                    break;
                case "S":
                    CurrentPosition.Direction = "E";
                    break;
                case "W":
                    CurrentPosition.Direction = "S";
                    break;
            }
        }

        private void RotateRight()
        {
            switch (CurrentPosition.Direction)
            {
                case "N":
                    CurrentPosition.Direction = "E";
                    break;
                case "E":
                    CurrentPosition.Direction = "S";
                    break;
                case "S":
                    CurrentPosition.Direction = "W";
                    break;
                case "W":
                    CurrentPosition.Direction = "N";
                    break;
            }
        }

        private void MoveForward(Crater crater)
        {
            switch (CurrentPosition.Direction)
            {
                case "N":
                    if (CurrentPosition.Y + 1 > crater.Height - 1)
                    { NoOfScuffs++; }
                    else
                    { CurrentPosition.Y++; }
                    break;
                case "E":
                    if (CurrentPosition.X + 1 > crater.Width - 1)
                    { NoOfScuffs++; }
                    else
                    { CurrentPosition.X++; }
                    break;
                case "S":
                    if (CurrentPosition.Y - 1 < 0)
                    { NoOfScuffs++; }
                    else
                    { CurrentPosition.Y--; }
                    break;
                case "W":
                    if (CurrentPosition.X - 1 < 0)
                    { NoOfScuffs++; }
                    else
                    { CurrentPosition.X--; }
                    break;
            }
        }

        private void ReportLocationAndDirection()
        {
            Console.WriteLine($"Position: { CurrentPosition.X } , { CurrentPosition.Y } Direction: { CurrentPosition.Direction }");
        }
    }
}