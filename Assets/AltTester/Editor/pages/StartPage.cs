using AltTester.AltTesterUnitySDK.Driver;

namespace test_case.pages
{
    public class MainMenuPage : BasePage
    {
        public MainMenuPage(AltDriver driver) : base(driver)
        {
        }

        public void LoadScene()
        {
            Driver.LoadScene("StartScene");
        }

        public AltObject RunButton { get => Driver.WaitForObject(By.NAME, "Button", timeout: 10); }


        public void PressStart()
        {
            if (RunButton != null)
            {
                RunButton.Click();
            }
        }
    }
}