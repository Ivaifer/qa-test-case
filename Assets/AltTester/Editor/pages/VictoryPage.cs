using AltTester.AltTesterUnitySDK.Driver;

namespace test_case.pages
{
    public class VictoryPage : BasePage
    {
        public VictoryPage(AltDriver driver) : base(driver)
        {
        }

        public AltObject RestartButton { get => Driver.WaitForObject(By.NAME, "RestartButton", timeout: 10); }


        public void PresstRestartButton()
        {
            if (RestartButton != null)
            {
                RestartButton.Click();
            }
        }
    }
}