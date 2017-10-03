using System;
using TestStack.White;
using NUnit.Framework;
using System.IO;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItemEvents;
using TestStack.White.UIItems.Finders;

namespace PaintTests.Menu
{
    [TestFixture]
    public class AvailabilityTests
    {
        [SetUp]
        public void Init()
        {
            String AppPath = @"E:\C#\2_10_17\Paint\Paint\Paint\bin\Debug";
            var applicationPath = Path.Combine(AppPath, "Paint.exe");
            Application application = Application.Launch(applicationPath);
            Window window = application.GetWindow("Paint", InitializeOption.NoCache);
        }

        [TearDown]
        public void Dispose()
        { /* ... */ }

        [Test]
        public void TestMethodPlus()
        {

            String AppPath = @"E:\C#\2_10_17\Paint\Paint\Paint\bin\Debug";
            var applicationPath = Path.Combine(AppPath, "Paint.exe");
#pragma warning disable CS0103 // The name 'applicationPath' does not exist in the current context
            Application application = Application.Launch(applicationPath);
#pragma warning restore CS0103 // The name 'applicationPath' does not exist in the current context
            Window window = application.GetWindow("Paint", InitializeOption.NoCache);

            window.Get <Button>("fileToolStripMenuItem").Click();
            window.Get <Button>("tabToolStripMenuItem").Click();
            window.Get <Button>("colorToolStripMenuItem").Click();
            window.Get <Button>("widthToolStripMenuItem").Click();
            window.Get <Button>("typeToolStripMenuItem").Click();
            application.Kill();          
        }
    }
}