﻿using NUnit.Framework;

namespace NBehave.Spec.NUnit
{
	[TestFixture]
	public abstract class SpecBase<T> : Spec.SpecBase<T>
	{
		[SetUp]
		public override void SpecSetup()
		{
			base.SpecSetup();
		}

		[TearDown]
		public override void SpecTeardown()
		{
			base.SpecTeardown();
		}

        [TestFixtureSetUp]
        public override void MainSetup()
        {
            base.MainSetup();
        }
        
        [TestFixtureTearDown]
        public override void MainTeardown()
        {
            base.MainTeardown();
        }
	}
}
