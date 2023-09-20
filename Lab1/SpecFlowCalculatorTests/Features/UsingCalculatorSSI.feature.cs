﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:4.0.0.0
//      SpecFlow Generator Version:4.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowCalculatorTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "4.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UsingCalculatorSSI")]
    public partial class UsingCalculatorSSIFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "UsingCalculatorSSI.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureSetupAsync()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunnerForAssembly(null, NUnit.Framework.TestContext.CurrentContext.WorkerId);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "UsingCalculatorSSI", @"		In order to calculate the Musa Logarithmic model's failures/intensities
		As a Software Quality Metric engineer
		I want to use my calculator to do this
		// Epic:
		// - Allow Engineers to calcuate defect densite of system
		// - Implement Custom Calculation for new total of Shipped Source Insturctions (SSI)
		// - Implement Calculatation Method of Musa Log Model to calculate failure intensity and expected failures", ProgrammingLanguage.CSharp, featureTags);
            await testRunner.OnFeatureStartAsync(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
            await testRunner.OnFeatureEndAsync();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculating Defect Density")]
        [NUnit.Framework.CategoryAttribute("SSI")]
        [NUnit.Framework.TestCaseAttribute("550", "50", "11", null)]
        [NUnit.Framework.TestCaseAttribute("100", "20", "5", null)]
        [NUnit.Framework.TestCaseAttribute("400", "70", "6", null)]
        public async System.Threading.Tasks.Task CalculatingDefectDensity(string value1, string value2, string value3, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SSI"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("value1", value1);
            argumentsOfScenario.Add("value2", value2);
            argumentsOfScenario.Add("value3", value3);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculating Defect Density", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 11
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 12
  await testRunner.GivenAsync("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 13
  await testRunner.WhenAsync(string.Format("I have entered {0} , {1} into the calculator and press defect_density", value1, value2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
  await testRunner.ThenAsync(string.Format("the defect result should be {0}", value3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Calculating new Defect Density")]
        [NUnit.Framework.CategoryAttribute("SSI")]
        [NUnit.Framework.TestCaseAttribute("550", "50", "25", "7", "0", "5", "8", null)]
        [NUnit.Framework.TestCaseAttribute("100", "20", "30", "0", "5", "0", "2", null)]
        [NUnit.Framework.TestCaseAttribute("400", "70", "50", "10", "200", "25", "5", null)]
        public async System.Threading.Tasks.Task CalculatingNewDefectDensity(string value1, string value2, string value3, string value4, string value5, string value6, string value7, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SSI"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("value1", value1);
            argumentsOfScenario.Add("value2", value2);
            argumentsOfScenario.Add("value3", value3);
            argumentsOfScenario.Add("value4", value4);
            argumentsOfScenario.Add("value5", value5);
            argumentsOfScenario.Add("value6", value6);
            argumentsOfScenario.Add("value7", value7);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Calculating new Defect Density", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 23
  await testRunner.GivenAsync("I have a calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 24
  await testRunner.WhenAsync(string.Format("I have entered {0} , {1} , {2} , {3} , {4} , {5} into the calculator and press ne" +
                            "w_defect_density", value1, value2, value3, value4, value5, value6), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
  await testRunner.ThenAsync(string.Format("the defect result should be {0}", value7), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
