using System;
using System.Threading;
using NUnit.Framework;
using AltTester.AltTesterUnitySDK.Driver;
using test_case.pages;

namespace test_case.tests
{
    public class GamePlayTests
    {
        AltDriver altDriver;
        MainMenuPage mainMenuPage;
        GamePlay gamePlayPage;
        VictoryPage victoryPage;
        [SetUp]
        public void Setup()
        {

            altDriver = new AltDriver();
            mainMenuPage = new MainMenuPage(altDriver);
            mainMenuPage.LoadScene();
            mainMenuPage.PressStart();
            gamePlayPage = new GamePlay(altDriver);
            victoryPage = new VictoryPage(altDriver);

        }
        
        [Test]
        public void StartGameGetToRedSquareReturnStartWindow()
        {
            gamePlayPage.GoRight();
            gamePlayPage.GoUp();
            gamePlayPage.GoLeft();
            victoryPage.PresstRestartButton();
        }
        
    }
}
