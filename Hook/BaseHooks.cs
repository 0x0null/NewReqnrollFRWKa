﻿namespace NewReqnrollFRWK.Hook
{
    [Binding]
    public sealed class BaseHooks
    {
        public InitializeDriver InitializeDriver;
        public ScenarioContext scenariocontext;
        
        public BaseHooks(InitializeDriver initializeDriver, 
            ScenarioContext context)
        {
            InitializeDriver = initializeDriver;
            scenariocontext = context;
        }

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            InitializeDriver.Start();
            scenariocontext.Add("browser", InitializeDriver.driver); //Step3
        }

        [AfterScenario]
        public void AfterScenario()
        {
            InitializeDriver.ShutDownBrowser();
        }
    }
}