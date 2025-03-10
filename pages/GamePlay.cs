using System;
using AltTester.AltTesterSDK.Driver;

namespace alttrashcat_tests_csharp.pages
{
    public class GamePlay : BasePage
    {
        public GamePlay(AltDriver driver) : base(driver)
        {
        }

        public AltObject PauseButton { get => Driver.WaitForObject(By.NAME, "pauseButton", timeout: 2); }
        public AltObject Character { get => Driver.WaitForObject(By.NAME, "PlayerPivot"); }

        public bool IsDisplayed()
        {
            if (PauseButton != null && Character != null)
            {
                return true;
            }
            return false;
        }
        public void PressPause()
        {
            PauseButton.Tap();
        }
        public int GetCurrentLife()
        {
            return Character.GetComponentProperty<int>("CharacterInputController", "currentLife", "Assembly-CSharp");
        }
        public void AvoidObstacles(int numberOfObstacles)
        {
            var character = Character;
            bool movedLeft = false;
            bool movedRight = false;
            for (int i = 0; i < numberOfObstacles; i++)
            {
                var allObstacles = Driver.FindObjectsWhichContain(By.NAME, "Obstacle");
                allObstacles.Sort((x, y) => x.worldZ.CompareTo(y.worldZ));
                allObstacles.RemoveAll(obs => obs.worldZ < character.worldZ);
                var obstacle = allObstacles[0];

                System.Console.WriteLine("Obstacle: " + obstacle.name + ", z:" + obstacle.worldZ + ", x:" + obstacle.worldX);
                System.Console.WriteLine("Next: " + allObstacles[1].name + ", z:" + allObstacles[1].worldZ + ", x:" + allObstacles[1].worldX);

                var stopwatch1 = new System.Diagnostics.Stopwatch();
                var ts1 = new TimeSpan();
                stopwatch1.Start();
                while (obstacle.worldZ - character.worldZ > 5 && ts1.Seconds < 15)
                {
                    obstacle = Driver.FindObject(By.ID, obstacle.id.ToString());
                    character = Driver.FindObject(By.NAME, "PlayerPivot");
                    ts1 = stopwatch1.Elapsed;
                }
                if (obstacle.name.Contains("ObstacleHighBarrier"))
                {
                    Driver.PressKey(AltKeyCode.DownArrow);
                }
                else
                if (obstacle.name.Contains("ObstacleLowBarrier") || obstacle.name.Contains("Rat"))
                {

                    Driver.PressKey(AltKeyCode.UpArrow);
                }
                else
                {
                    if (obstacle.worldZ == allObstacles[1].worldZ)
                    {
                        if (obstacle.worldX == character.worldX)
                        {
                            if (allObstacles[1].worldX == -1.5f)
                            {
                                Driver.PressKey(AltKeyCode.RightArrow);
                                movedRight = true;
                            }
                            else
                            {
                                Driver.PressKey(AltKeyCode.LeftArrow);
                                movedLeft = true;
                            }
                        }
                        else
                        {
                            if (allObstacles[1].worldX == character.worldX)
                            {
                                if (obstacle.worldX == -1.5f)
                                {
                                    Driver.PressKey(AltKeyCode.RightArrow);
                                    movedRight = true;
                                }
                                else
                                {
                                    Driver.PressKey(AltKeyCode.LeftArrow);
                                    movedLeft = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (obstacle.worldX == character.worldX)
                        {
                            Driver.PressKey(AltKeyCode.RightArrow);
                            movedRight = true;
                        }
                    }
                }
                var stopwatch2 = new System.Diagnostics.Stopwatch();
                var ts2 = new TimeSpan();
                stopwatch2.Start();
                while (character.worldZ - 3 < obstacle.worldZ && character.worldX < 99 && ts2.Seconds < 15)
                {
                    obstacle = Driver.FindObject(By.ID, obstacle.id.ToString());
                    character = Driver.FindObject(By.NAME, "PlayerPivot");
                    ts2 = stopwatch2.Elapsed;
                }
                if (movedRight)
                {
                    Driver.PressKey(AltKeyCode.LeftArrow);
                    movedRight = false;
                }
                if (movedLeft)
                {
                    Driver.PressKey(AltKeyCode.RightArrow);
                    movedRight = false;
                }
            }


        }
    }
}