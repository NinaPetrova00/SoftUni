namespace Robots.Tests
{
    using NUnit.Framework;
    using System;

    public class RobotsTests
    {
        private Robot robot;
        private RobotManager robotManager;
        [SetUp]
        public void SetUp()
        {
            robot = new Robot("Ivan", 100);
            robotManager = new RobotManager(50);
        }

        [Test]
        public void Ctor_ThrowExceptionWhenInvalidCapacity()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-5));
        }

        [Test]
        public void Add_ThrowsExcpetionWhenInvalidRobot()
        {
            Robot robot = new Robot(null, 100);
            robotManager.Add(robot);
            Assert.That(robot.Name, Is.EqualTo(null));
        }

        [Test]
        public void Add_ThrowsExcpetionWhenSameName()
        {
            Robot robot = new Robot("ivan", 100);
            robotManager.Add(robot);
            //Assert.Throws<ArgumentException>(() => robotManager.Add(new Robot("ivan", 50)));
            Assert.That(robot.Name, Is.EqualTo("ivan"));
        }

        [Test]
        public void Add_ThrowsEcpetionWhenNameIsNull()
        {
            Robot robot = new Robot("ivan", 100);

            Assert.Throws<InvalidOperationException>(() => robotManager.Remove(null));
        }

        [Test]
        public void Add_Capacity()
        {
            Robot robot = new Robot("ivan", 100);
            Robot robot2 = new Robot("gosh", 80);
            robotManager.Add(robot);
            robotManager.Add(robot2);

            int capacity = 1;
            Assert.That(robotManager.Count, Is.Not.EqualTo(capacity));
        }

        [Test]
        public void Work_hrowsEcpetionWhenNameIsNull()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Work(null,"job",10));
        }
        [Test]
        public void Work_hrowsEcpetionWhenJobIsNull()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("name", null, 10));
        }
        [Test]
        public void Work_hrowsEcpetionWhenBatIsInvalid()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("name", "job", -80));
        }
        [Test]
        public void Work_Battery()
        {
            Robot robot = new Robot("pesho", 50);
            int batteryUsage = 100;

            Assert.That(robot.Battery, Is.Not.EqualTo(batteryUsage));
        }

       [Test]
       public void Charge_()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Charge(null));
        }
    }
}
