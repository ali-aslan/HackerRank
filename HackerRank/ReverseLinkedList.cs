using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class ReverseLinkedList
    {
        public class Solution
        {

            class SinglyLinkedListNode
            {
                public int data;
                public SinglyLinkedListNode next;

                public SinglyLinkedListNode(int nodeData)
                {
                    this.data = nodeData;
                    this.next = null;
                }
            }

            class SinglyLinkedList
            {
                public SinglyLinkedListNode head;
                public SinglyLinkedListNode tail;

                public SinglyLinkedList()
                {
                    this.head = null;
                    this.tail = null;
                }

                public void InsertNode(int nodeData)
                {
                    SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                    if (this.head == null)
                    {
                        this.head = node;
                    }
                    else
                    {
                        this.tail.next = node;
                    }

                    this.tail = node;
                }
            }

            static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
            {
                while (node != null)
                {
                    Console.Write(node.data);

                    node = node.next;

                    if (node != null)
                    {
                        Console.Write(sep);
                    }
                }
            }

            class Result
            {

                /*
                 * Complete the 'reverse' function below.
                 *
                 * The function is expected to return an INTEGER_SINGLY_LINKED_LIST.
                 * The function accepts INTEGER_SINGLY_LINKED_LIST llist as parameter.
                 */

                /*
                 * For your reference:
                 *
                 * SinglyLinkedListNode
                 * {
                 *     int data;
                 *     SinglyLinkedListNode next;
                 * }
                 *
                 */

                public static SinglyLinkedListNode reverse(SinglyLinkedListNode llist)
                {
                    if (llist.next == null)
                    {
                        return llist;
                    }

                    SinglyLinkedListNode prev = new SinglyLinkedListNode(llist.data);
                    SinglyLinkedListNode curr = llist.next;
                    while (true)
                    {
                        SinglyLinkedListNode node = new SinglyLinkedListNode(curr.data);
                        node.next = prev;

                        prev = node;

                        if (curr.next != null)
                        {
                            curr = curr.next;
                        }
                        else
                        {
                            return node;
                        }
                    }

                }

            }

            public static void Run()
            {

                SinglyLinkedList llist = new SinglyLinkedList();

                llist.InsertNode(1);
                llist.InsertNode(2);
                llist.InsertNode(3);
                llist.InsertNode(4);
                llist.InsertNode(5);

                SinglyLinkedListNode llist1 = Result.reverse(llist.head);

                PrintSinglyLinkedList(llist1, " ");
                Console.WriteLine();




            }
        }
    }
}

