using Moq;
using NUnit.Framework;
using PlutoRover.RoverCore.Interface;

namespace PlutoRoverTests
{
    public class MovementsProviderTest
    {
        [Test]
        public void ChecksMoveForward()
        {
            var MovementsProviderRepo = new Mock<IMovementsProvider>();
            MovementsProviderRepo.Object.MoveForward();
            MovementsProviderRepo.Verify(m => m.MoveForward(), Times.Once);
        }

        [Test]
        public void ChecksMoveBackforward()
        {
            var MovementsProviderRepo = new Mock<IMovementsProvider>();
            MovementsProviderRepo.Object.MoveBackward();
            MovementsProviderRepo.Verify(m => m.MoveBackward(), Times.Once);
        }

        [Test]
        public void ChecksRotateRight()
        {
            var MovementsProviderRepo = new Mock<IMovementsProvider>();
            MovementsProviderRepo.Object.MoveRight();
            MovementsProviderRepo.Verify(m => m.MoveRight(), Times.Once);
        }

        [Test]
        public void ChecksRotateLeft()
        {
            var MovementsProviderRepo = new Mock<IMovementsProvider>();
            MovementsProviderRepo.Object.MoveLeft();
            MovementsProviderRepo.Verify(m => m.MoveLeft(), Times.Once);
        }
    }
}
