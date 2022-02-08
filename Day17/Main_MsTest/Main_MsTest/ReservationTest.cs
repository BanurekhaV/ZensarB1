using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Main_DLL;

namespace Main_MsTest
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void Cancellation_ByAdmin_To_ReturnTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act 
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //assert
            Assert.IsTrue(result);

        }
        [TestMethod]
        public void Cancellation_ByMadeBy_ReturnTrue()
        {
            var user = new User();
            var reservation = new Reservation() { MadeBy = user };
            var result = reservation.CanBeCancelledBy(reservation.MadeBy);
            Assert.IsTrue(result);
        }
       [TestMethod]
       public void Cancellation_By_Others_To_Return_False()
        {
            var reservation = new Reservation { MadeBy = new User() };
            var result = reservation.CanBeCancelledBy(new User());
            Assert.IsFalse(result);
        }
    }
}
