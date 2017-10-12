﻿using NUnit.Framework;
using NWaves.Transforms;

namespace NWaves.Tests.Transforms
{
    [TestFixture]
    public class TestDct
    {
        readonly double[] _test = { 0.5, 0.2, 0.1, 0.6, 0.1, 0, 0.3, 0.8 };

        [Test]
        public void TestDct1()
        {
            double[] res = new double[8];
            double[] resDct1 = { 1.95, -0.06648744, 0.3088146, -0.57409388, 0.88508551, 0.34058132, 0.10609989, -0.45 };

            Transform.Dct1(_test, res, 8);

            Assert.That(res, Is.EqualTo(resDct1).Within(1e-5));
        }

        [Test]
        public void TestDct2()
        {
            double[] res = new double[8];
            double[] resDct2 = { 2.6, -0.22428036, 0.70740109, -0.6057955, 0.98994949, 0.3666513, -0.13994175, -0.41021575 };

            Transform.Dct2(_test, res, 8);

            Assert.That(res, Is.EqualTo(resDct2).Within(1e-5));
        }

        [Test]
        public void TestDct3()
        {
            double[] res = new double[8];
            double[] resDct3 = { 1.37901474, -0.45482265, 0.60600341, -0.9654346, 1.19246999, 0.23036627, 0.33561026, -0.32320742 };

            Transform.Dct3(_test, res, 8);

            Assert.That(res, Is.EqualTo(resDct3).Within(1e-5));
        }

        [Test]
        public void TestIdct1()
        {
            double[] res = new double[8];
            double[] resDct1 = { 1.95, -0.06648744, 0.3088146, -0.57409388, 0.88508551, 0.34058132, 0.10609989, -0.45 };

            Transform.Idct1(resDct1, res, 8);

            Assert.That(res, Is.EqualTo(_test).Within(1e-5));
        }

        [Test]
        public void TestIdct2()
        {
            double[] res = new double[8];
            double[] resDct2 = { 2.6, -0.22428036, 0.70740109, -0.6057955, 0.98994949, 0.3666513, -0.13994175, -0.41021575 };

            Transform.Idct2(resDct2, res, 8);

            Assert.That(res, Is.EqualTo(_test).Within(1e-5));
        }

        [Test]
        public void TestIdct3()
        {
            double[] res = new double[8];
            double[] resDct3 = { 1.37901474, -0.45482265, 0.60600341, -0.9654346, 1.19246999, 0.23036627, 0.33561026, -0.32320742 };

            Transform.Idct3(resDct3, res, 8);

            Assert.That(res, Is.EqualTo(_test).Within(1e-5));
        }
    }
}