using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using StacksAndQueues;


namespace XUnitTestProject1
{

    public class QueueTests
    {
        [Fact]
        public void CanEnqueueIntoQueue()
        {
            // Arrange
            Queue que = new Queue();

            // Act
            que.Enqueue("Josie Cat");
            que.Enqueue("Belle Kitty");

            // Assert
            Assert.Equal("Josie Cat", que.Front.Value);
        }
    }
}
