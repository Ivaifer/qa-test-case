using AltTester.AltTesterUnitySDK.Driver;

namespace test_case.pages
{
    public class BasePage
    {
        AltDriver driver;

        public AltDriver Driver { get => driver; set => driver = value; }
        public BasePage(AltDriver driver)
        {
            Driver = driver;
        }
    }
}