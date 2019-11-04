using NUnit.Framework;
using testCore;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsAdminTest()
        {
            var reservation = new Reservation();
            var result = reservation.CanBeCanceledBy(new User { IsAdmin = true });
            Assert.IsTrue(true);
        }
        [Test]
        public void IsMadeByTest()
        {
            var user = new User();
            var reservation = new Reservation { MadeBy = user };
            var result = reservation.CanBeCanceledBy(user);
            Assert.IsTrue(true);
        }
        [Test]
        public void RandomUserTest()
        {
            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanBeCanceledBy(new User());
            Assert.IsFalse(result);
        }
    }
}