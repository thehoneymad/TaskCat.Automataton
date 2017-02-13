﻿using NUnit.Framework;
using System.IO;
using System.Reflection;

namespace TaskCat.Automaton.Tests
{
    [TestFixture]
    public class TestFiniteStateMachine
    {
        public string ExecutingPath => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        [Test]
        public void TestCreation_NotNull()
        {
            var jsonFsm = File.ReadAllText($"{ExecutingPath}\\SampleFSM.json");
            Assert.IsNotNull(jsonFsm);

            var machine = FiniteStateMachine.FromJson(jsonFsm);
            Assert.IsNotNull(machine);
            Assert.AreEqual("ClassifiedDelivery", machine.Name);
            Assert.AreEqual("default", machine.Variant);
            Assert.IsNotNull(machine.Nodes);
            Assert.IsNotNull(machine.Events);
        }
    }
}
