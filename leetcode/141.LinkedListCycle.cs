static bool HasCycle(ListNode head)
{
  if (head == null || head.next == null)
  {
    return false;
  }
  Dictionary<ListNode, ListNode> dict = new();
  ListNode cursor = head;
  while (cursor != null)
  {
    if (cursor == null || cursor.next == null)
    {
      break;
    }
    if (dict.ContainsKey(cursor.next) && dict[cursor.next] == cursor.next)
    {
      return true;
    }
    dict.Add(cursor, cursor);
    cursor = cursor.next;
  }
  return false;
}