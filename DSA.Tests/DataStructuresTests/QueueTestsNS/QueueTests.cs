using DSA.DataStructures.QueueNS;

namespace DSA.Tests.DataStructuresTests.QueueTestsNS
{
  public class QueueTests
  {
    private readonly IQueue<int> queue;
    public QueueTests()
    {
      this.queue = new DSA.DataStructures.QueueNS.Queue<int>();
    }

    [Fact]
    public void Enqueue_ShouldIncreaseLength()
    {
      queue.Enqueue(1);
      queue.Enqueue(2);

      Assert.Equal(2, queue.Length());
    }

    [Fact]
    public void Enqueue_ShouldLeaveQueueAtLogicalOrder()
    {
      int[] compareArray = new int[] { 1, 2, 3 };

      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);

      Assert.True(Enumerable.SequenceEqual(compareArray, queue));
    }

    [Fact]
    public void Peek_ShouldThrowExceptionWhenQueueIsEmpty()
    {
      Assert.Throws<Exception>(() => queue.Peek());
    }

    [Fact]
    public void Peek_ShouldReturnFirstItem()
    {
      queue.Enqueue(10);
      queue.Enqueue(20);
      queue.Enqueue(30);

      Assert.Equal(10, queue.Peek());
    }

    [Fact]
    public void Peek_ShouldLeaveTheQueueInLogicalOrder()
    {
      int[] compareArray = new int[] { 1, 2, 3 };
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Peek();

      Assert.True(Enumerable.SequenceEqual(compareArray, queue));
    }

    [Fact]
    public void Dequeue_ShouldThrowExceptionWhenQueueIsEmpty()
    {
      Assert.Throws<Exception>(() => queue.Dequeue());
    }

    [Fact]
    public void Dequeue_ShouldReturnFirstItem()
    {
      queue.Enqueue(10);
      queue.Enqueue(20);
      queue.Enqueue(30);

      Assert.Equal(10, queue.Dequeue());
    }

    [Fact]
    public void Dequeue_ShouldLeaveTheQueueInLogicalOrder()
    {
      int[] compareArray = new int[] { 2, 3 };
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Dequeue();
      Assert.True(Enumerable.SequenceEqual(compareArray, queue));
    }

    [Fact]
    public void Dequeue_ShouldDecreaseLength()
    {
      int[] compareArray = new int[] { 2, 3 };
      queue.Enqueue(1);
      queue.Enqueue(2);
      queue.Enqueue(3);
      queue.Dequeue();
      Assert.Equal(2, queue.Length());
    }
  }
}