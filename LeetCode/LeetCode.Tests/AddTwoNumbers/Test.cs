using LeetCode.AddTwoNumbers;

namespace LeetCode.Tests.AddTwoNumbers;

public class Test
{
    [Fact]
    public void Test1()
    {
        var l1 = new ListNode(2);
        var l2 = new ListNode(5);

        var solution = new Solution();

        var result = solution.AddTwoNumbers(l1, l2);

        Assert.Equal(7, result.val);
    }

    [Fact]
    public void Test2()
    {
        var l1 = new ListNode(9);
        var l2 = new ListNode(5);

        var solution = new Solution();

        var result = solution.AddTwoNumbers(l1, l2);

        Assert.Equal(4, result.val);
        Assert.Equal(1, result.next.val);
    }

    [Fact]
    public void Test3()
    {
        var l1 = new ListNode(2, new ListNode(3));
        var l2 = new ListNode(5, new ListNode(3));

        var solution = new Solution();

        var result = solution.AddTwoNumbers(l1, l2);

        Assert.Equal(7, result.val);
        Assert.NotNull(result.next);
        Assert.Equal(6, result.next.val);
    }

    [Fact]
    public void Test4()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        var solution = new Solution();

        var result = solution.AddTwoNumbers(l1, l2);

        Assert.Equal(7, result.val);
        Assert.Equal(0, result.next.val);
        Assert.Equal(8, result.next.next.val);
        Assert.Null(result.next.next.next);
    }

    [Fact]
    public void Test5()
    {
        var l1 = new ListNode(0);
        var l2 = new ListNode(0);

        var solution = new Solution();

        var result = solution.AddTwoNumbers(l1, l2);

        Assert.Equal(0, result.val);
    }
    
    [Fact]
    public void Test6()
    {
        var l1 = new ListNode(2);
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        var solution = new Solution();

        var result = solution.AddTwoNumbers(l1, l2);

        Assert.Equal(7, result.val);
        Assert.Equal(6, result.next.val);
        Assert.Equal(4, result.next.next.val);
    }
}