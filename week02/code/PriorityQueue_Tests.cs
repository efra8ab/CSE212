using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue 3 items with different priorities
    // Expected Result: Tim, Sue, Bob
    // Defect(s) Found: At first the Dequeue method was not removing items from the queue
    // also the priority logic was not correct. This was returning incorrect order and possible duplicates
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        string[] expected = { "Tim", "Sue", "Bob" };
        string[] actual = new string[3];

        for (int i = 0; i < expected.Length; i++)
        {
            actual[i] = priorityQueue.Dequeue();
        }

        CollectionAssert.AreEqual(expected, actual);

    }

    [TestMethod]
    // Scenario: Enqueue 3 items with different priorities
    // Expected Result: Tim, Sue, Bob, Peter, George, Regina
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 7);
        priorityQueue.Enqueue("Tim", 10);
        priorityQueue.Enqueue("Sue", 8);
        priorityQueue.Enqueue("Peter", 7);
        priorityQueue.Enqueue("Regina", 1);
        priorityQueue.Enqueue("George", 2);

        string[] expected = { "Tim", "Sue", "Bob", "Peter", "George", "Regina" };
        string[] actual = new string[6];

        for (int i = 0; i < expected.Length; i++)
        {
            actual[i] = priorityQueue.Dequeue();
        }

        CollectionAssert.AreEqual(expected, actual);
    }

    // Add more test cases as needed below.
}

