using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
        public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Ascending)
            if (list == null)
            {
                return null;
            }
            LinkedList<int> sortedList = new LinkedList<int>(list);
            for (var node = sortedList.First; node != null; node = node.Next)
            {
                var minNode = node;
                for (var current = node.Next; current != null; current = current.Next)
                {
                    if (current.Value < minNode.Value)
                    {
                        minNode = current;
                    }
                }
                if (minNode != node)
                {
                    int temp = node.Value;
                    node.Value = minNode.Value;
                    minNode.Value = temp;
                }
            }
            return sortedList;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากมากไปน้อย (Descending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากมากไปน้อยแล้ว</returns>
        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // TODO: Implement sorting algorithm for LinkedList<int> (Descending)
            if (list == null)
            {
                return null;
            }
            LinkedList<int> sortedList = new LinkedList<int>(list);
            for (var node = sortedList.First; node != null; node = node.Next)
            {
                var minNode = node;
                for (var current = node.Next; current != null; current = current.Next)
                {
                    if (current.Value > minNode.Value)
                    {
                        minNode = current;
                    }
                }
                if (minNode != node)
                {
                    int temp = node.Value;
                    node.Value = minNode.Value;
                    minNode.Value = temp;
                }
            }
            return sortedList;
        }
    }
}
