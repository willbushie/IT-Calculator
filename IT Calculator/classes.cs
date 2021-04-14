﻿/*
 * CSC370 - Group Project - IT Calculator
 * 
 * Purpose: 
 *  This is an IT calculator to help aid in simple conversion
 *  between different bases, as well as allow easy base 2
 *  arithmatic. 
 * 
 * Developers on the project & roles:
 *      Hannah Neymeyer - Team Lead
 *      Caden Flowers - Front End Developer
 *      Nicholas Johnson - Architect/Designer
 *      William Bushie - Programmer
 * 
 *
 * 
 * 
 * ======================================
 *           HELPFUL CLASSES
 * ======================================
 * 
 * This section of code contains all of the added classes that allow more
 * unique features for the application.
 * 
 */


using System;


/*
 * This class is used to implement a doubly linked list.
 * This file helps with the conversion of base 2 to base 10 numbers.
 */
namespace IT_Calculator
{
    public class LinkedList
    {
        // declaration of LinkedList attributes
        public Node head;
        public Node tail;
        public int length;

        // initialzation of linked list - it begins empty
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.length = 0;
        }

        // this method adds a node to the linked list
        public void addNode(Node newNode)
        {
            // put the newNode at the front if the linked list is empty
            if (this.length == 0)
            {
                // set the head & tail to newNode
                this.head = newNode;
                this.tail = newNode;

                // update the list's length
                this.length++;
            }
            else if (this.length > 0)
            {
                // link the current tail to newNode - call setNodeAfter()
                this.tail.setNodeAfter(newNode);

                // link the newNode to current tail - call setNodeBefore()
                newNode.setNodeBefore(this.tail);

                // set the tail to newNode
                this.tail = newNode;

                // update the list's length
                this.length++;
            }
        }

        // this method takes a linked list contents and returns the list contents as a single int
        // this is useful when converting between bases - base2ToBase10() for example will use this method\
        // takes a bool "reverse" parameter - if the list needs to be reverse from the 
        public int contentsToInt(bool reverse)
        {
            // value to return once the process is complete
            String intToReturnString = "";

            // check if the return needs to reverse the linked list
            if (reverse == true)
            {
                // walk through the list starting from the tail
                // store the node currently being check
                Node currNode = this.tail;

                // walk through the list and update intToReturnString
                for (int count = 0; count < this.length; count++)
                {
                    // update intToReturnString
                    intToReturnString = intToReturnString + currNode.payload.ToString();
                    // advance currNode
                    currNode = currNode.nodeBefore;
                }
            }
            else if (reverse == false)
            {
                // walk through the list starting from the head
            }

            // convert and return the final value
            return int.Parse(intToReturnString);
        }

        // this method empties a linked list - after it is done being used
        public void clearLinkedList(LinkedList list)
        {
            // loop through the linked list and remove all nodes starting at tail
            for (int count = 0; count < this.length; count++)
            {
                // reassign this.tail and clear the current tail node - call Node.removeNode()
                this.tail = this.tail.removeNode();
            }
        }
    }


    /*
     * This class is used to implement nodes which will be used inside of a linked list instance.
     * This file helps with the conversion of base 2 to base 10 numbers.
     */
    public class Node
    {
        // public node attributes
        public Node nodeBefore;
        public int payload;
        public Node nodeAfter;

        // instance method for a node
        public Node(int payload)
        {
            this.nodeBefore = null;
            this.payload = payload;
            this.nodeAfter = null;
        }

        // this method sets the nodeAfter of a node (to link the linked list together) (allowing singly LL)
        public void setNodeAfter(Node afterNode)
        {
            this.nodeAfter = afterNode;
        }

        // this method set the nodeBefore of a node (to link the linked list together) (allowing doubly LL)
        public void setNodeBefore(Node beforeNode)
        {
            this.nodeBefore = beforeNode;
        }

        // this method will be used in conjunction with LinkedList.clearLinkedList(LinkedList) - zero out a nodes payload
        // it will also return the nodeToRemove's nodeBefore for easy assignment of nodeToRemove to LinkedList.tail
        public Node removeNode()
        {
            // store nodeToRemove's nodeBefore to return for reassinging LinkedList.tail
            Node nodeToReturn = this.nodeBefore;

            // null out the node's payload
            this.payload = 0;

            // null out the node's beforeNode & afterNode
            this.nodeBefore = null;
            this.nodeAfter = null;

            // return nodeToRemove's nodeBefore
            return nodeToReturn;
        }
    }
}