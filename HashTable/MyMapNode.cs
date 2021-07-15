using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable
{
    public struct KeyValue<k, V>
    {
        public k Key { get; set; }
        public V Value { get; set; }
    }
    public class MyMapNode<K,V>
    {
         int size;
         public  LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        { 
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }

        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> LinkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            LinkedList.AddLast(item);
        }

      

        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }

        public LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> LinkedList = items[position];
            if (LinkedList == null)
            {
                LinkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = LinkedList;
            }
            return LinkedList;
        }

        public int Check(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> LinkedListPosition = GetLinkedList(position);
            int count = 1;
            bool found = false;
            KeyValue<K, V> founditem = default(KeyValue<K, V>);
            foreach(KeyValue<K,V> keyValue in LinkedListPosition)
            {
                if(keyValue.Key.Equals(key))
                {
                    count = Convert.ToInt32(keyValue.Value) + 1;
                    found = true;
                    founditem = keyValue;
                }
            }
            if(found)
            {
                LinkedListPosition.Remove(founditem);
                return count;
            }
            else
            {
                return 1;
            }
        }
        

       
        public void Display(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> LinkedListPosition = GetLinkedList(position);
            foreach(KeyValue<K, V> keyValue in LinkedListPosition)
            {
                if(keyValue.Key.Equals(key))
                {
                    Console.WriteLine("Key:" + keyValue.Key + "\t Value : " + keyValue.Value);
                }
            }
        }
         
    }
   

}
