using System;
using AltTester.AltTesterUnitySDK.Driver;

namespace test_case.pages
{
    public class GamePlay : BasePage
    {
        public GamePlay(AltDriver driver) : base(driver)
        {
        }

        public AltObject RightButton { get => Driver.WaitForObject(By.NAME, "RightButton", timeout: 2); } 
        public AltObject UpButton { get => Driver.WaitForObject(By.NAME, "UpButton", timeout: 2); }
        public AltObject LeftButton { get => Driver.WaitForObject(By.NAME, "LeftButton", timeout: 2); }

        public void GoRight()
        {
            Driver.HoldButton(RightButton.GetScreenPosition(), 0.8f);
        }

        public void GoUp()
        {
            Driver.HoldButton(UpButton.GetScreenPosition(), 2.2f);
        }

        public void GoLeft()
        {
            Driver.HoldButton(LeftButton.GetScreenPosition(), 2.2f);
        }
    }
}