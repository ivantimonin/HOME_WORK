using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Tree
    {
        private Node root;               
        
        public void Add_node(int number)
        {
            Node newNode = new Node(number);

            if (root == null)
            {
                root = newNode;
                return;
            }

            Node parent = root;
            Node current = root;
            while (current != null)
            {
                parent = current;
                if (number > current.number)
                {
                    current = current.right;
                }
                else if (number < current.number)
                {
                    current = current.left;
                }                
            }

            if (parent.number < newNode.number)
            {
                parent.right = newNode;// вставка вправо
            }
            else
            {
                parent.left = newNode;// вставка влево
            }
        }

        public bool Find(int number)
        {
            Node current = root;
            while (true)
            {
                if (current.number > number)
                {
                    current = current.right;
                }
                else if (current.number < number)
                {
                    current = current.left;
                }
                else if (current.number == number)
                {
                    return true;
                }
                return false;
            }
        }

        public void Del(int number)
        {                    
            Node parent = root;
            Node current = root;
            int flag=-1;
            while (true)
            {                
                if (current.number == number)
                {
                    int number_p = Check_namber_del_node(current);// сколько потомков в удал. узле
                    switch (number_p)
                    {
                        case 1:
                            Del_node_whith_one_p(parent, current, flag);
                            break;
                        case 2:
                            Del_node_whith_two_p(parent, current, flag);
                            break;
                        case 0:
                            Del_node(parent, number, flag);
                            break;
                    }
                    break;
                }
                else if (current.number < number)
                {
                    parent = current;
                    current = current.right;
                    flag = 1;//1 это право
                }
                else if (current.number > number)
                {
                    parent = current;
                    current = current.left;
                    flag = 0;//0 это лево
                }
                if (current == null)
                {
                    break;
                }
            }
        }

        private void Del_node_whith_one_p(Node parent, Node for_del, int flag)
        {
            if (parent.number == for_del.number)
            {
                if (root.left == null)
                { root = root.right; }
                if (root.right == null)
                { root = root.left; }               
            }
            if (flag == 0)
            {
                if (for_del.right == null)
                {
                    parent.left = for_del.left;
                }
                else { parent.left = for_del.right; }
            }
            if (flag == 1)
            {
                if (for_del.right == null)
                {
                    parent.right = for_del.left;
                }
                else { parent.left = for_del.right; }
            }
        }

        private void Del_node_whith_two_p(Node parent, Node for_del, int flag)
        {
            // поиск приемника
            Node current_ = for_del.right;
            Node parent_ = for_del.right;
            bool p_left = true;//приемник левый
            if (for_del.right.left == null)
            {
                p_left = false;//приемник правый
            }
            Node up_parent= for_del;
            while (current_ != null)
            {
                up_parent = parent_;// это папа приемника
                parent_ = current_;// это приемник
                current_ = current_.left;               
            }
            if (p_left == false)
            {
                if (for_del == root)
                {
                    root = root.right;
                    root.left = for_del.left;                    
                }
                else
                {
                    parent.right = for_del.right;
                    parent_.left = for_del.left;
                }                
            }
            if (p_left == true)
            {
                if (for_del == root)
                {
                    up_parent.left = parent_.right;
                    root = parent_;
                    root.left = for_del.left;
                    root.right = for_del.right;
                    
                }
                else
                {
                    for_del.right.left = parent_.right;
                    parent.right = parent_;
                    parent_.left = for_del.left;
                    parent_.right = for_del.right;
                }                               
            }
        }

        private void Del_node(Node parent, int number, int flag)
        {
            // первый варинт: если удаляемый узел корневой и у него нет ни правого ни левого потомка
            if (number == root.number)
            {
                root = null;
            }
            if (flag == 1)
            {
                parent.right = null;
            }
            if (flag == 0)
            {
                parent.left = null;
            }            
        }

        private int Check_namber_del_node(Node node)// метод определит ко-во потомков удаляемого узла
        {
            if (node.left != null && node.right != null)
            {
                return 2;
            }
            else if (node.left != null || node.right != null)
            {
                return 1;
            }
            return 0;
        }

        public void Show_tree()
        {
            int i = 1;
            int value = 30;
            string space = new string(' ', value);// да, знаю, для больших деревьев возможна ошибка
            
            Visit_node(root, i, value, space );
           
        }
        
        private void Visit_node(Node node, int i, int value, string space="" )
        {
           
            if (node == null)
            {                
                return;
            }
            
            Console.WriteLine($"Уровень {i++}) {space} {node.number}");
          
            space = new string(' ', value=value-5);
            Visit_node(node.left, i, value, space );

            space = new string(' ', value=value + 10);
            Visit_node(node.right, i, value, space);
           
        }

        
    }
}
