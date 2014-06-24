using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TreeViewer
{
        class Student
        {
            public int id;
            public Student left;
            public Student right;
            private Point location;


            public Student(int id, Point Location)
            {
                this.id = id;
                this.Location = Location;
                left = null;
                right = null;
            }
            public Student(int id)
            {
                this.id = id;
                this.Location = location;
                left = null;
                right = null;
            }

            public void Addleft(Student s)
            {
                if (left == null)
                {
                    left = s;
                }
                else
                {
                    left.Add(s);
                }
            }
            public void Addright(Student s)
            {
                if (right == null)
                {
                    right = s;
                }
                else
                {
                    right.Add(s);
                }
            }

            public void Add(Student s)
            {
                if (s.id < id)
                {
                    Addleft(s); //재귀함수. 멋짐 와 
                    //와 개멋짐!!!!!!!!!!!! by namse
                }
                else if (s.id > id)
                {
                    Addright(s);
                }
                else
                {
                   
                    //Console.WriteLine (" ERRRRORRRR");
                }
            }


            public Student Remove(int delid)
            {
                Student root = this;
                Student prev = null;
                Student del = null;
                del = DeleteStudent(delid, ref prev);
                if (del.left == null)
                {
                    if (del.right == null)
                    {
                        // 자식노드가 하나도 없는 경우
                        if (prev.left == del)
                        {
                            prev.left = null;
                            return root;
                        }
                        else
                        {
                            prev.right = null;
                            return root;
                        }
                    }
                    else
                    {
                        // 오른쪽 자식노드만 있는 경우 
                        prev.right = del.right;
                        return root;
                    }

                }
                else
                {
                    if (del.right == null)
                    {
                        // 왼쪽 자식노드만 있는 경우 
                        prev.left = del.left;
                        return root;
                    }
                    else
                    {
                        // 자식 노드가 전부 있는 경우
                        Student grandchild = null;
                        if (prev.left == del)
                        {
                            //prev의 왼쪽 자식 노드이었던 경우
                            if (del.left.right != null)
                            {
                                // 왼쪽 > 오른쪽 밑에 노드가 존재하는 경우 

                                grandchild = del.left.right;
                                prev.left = grandchild;
                                del.left.right = null;

                                GrandChildReplace(grandchild, del, prev.left);

                                return root;
                            }
                            else if (del.right.left != null)
                            {
                                //  오른쪽 > 왼쪽 밑에 노드가 존재하는 경우


                                grandchild = del.right.left;
                                prev.left = grandchild;
                                del.right.left = null;

                                GrandChildReplace(grandchild, del, prev.left);

                                return root;
                            }
                            else
                            {
                                prev.left = del.left;
                                del.left.right = del.right;
                                return root;
                            }
                        }
                        else
                        {
                            // prev의 오른쪽 자식 노드이었던  경우 
                            if (del.left.right != null)
                            {
                                // 왼쪽 오른쪽 밑에 노드가 존재하는 경우 

                                grandchild = del.left.right;
                                prev.right = grandchild;
                                del.left.right = null;

                                GrandChildReplace(grandchild, del, prev.left);

                                return root;

                            }
                            else if (del.right.left != null)
                            {
                                //  오른쪽 왼쪽 밑에  노드가 존재하는 경우

                                grandchild = del.right.left;
                                prev.right = grandchild;
                                del.right.left = null;

                                GrandChildReplace(grandchild, del, prev.right);

                                return root;

                            }
                            else
                            {
                                prev.right = del.left;
                                del.left.right = del.right;
                                return root;
                            }
                        }
                    }
                }
            }

            public void GrandChildReplace(Student grandchild, Student del, Student prev_next)
            {
                while (grandchild.left != null)
                {
                    grandchild = grandchild.left;
                }
                grandchild.left = del.left;
                grandchild = prev_next;

                while (grandchild.right != null)
                {
                    grandchild = grandchild.right;
                }
                grandchild.right = del.right;
            }


            public Student DeleteStudent(int id, ref Student prev)
            {
                if (id == this.id)
                {
                    return this;
                }
                else if (left == null && right == null)
                {
                    //Console.WriteLine ("StudentFind: Not Found {0} ", id);

                    return null;
                }
                else if (left != null && id < this.id)
                {
                    prev = this;
                    return left.DeleteStudent(id, ref prev);
                }
                else if (right != null && id > this.id)
                {
                    prev = this;
                    return right.DeleteStudent(id, ref prev);
                }
                else
                {
                    return null;
                }
            }
           public void ConsolePrintSubtree(int level)
            {
                if (left != null)
                {
                    left.ConsolePrintSubtree(level + 1);
                }              
                for (int i = 0; i < level; i++)
                {
                    Console.Write("        ");
                }

                Console.WriteLine ("{0}", id);
           
                if (right != null)
                {
                    right.ConsolePrintSubtree(level + 1);
                }
            }

            public Student FindStudent(int id)
            {
                if (id == this.id)
                {
                    return this;
                }
                else if (left == null && right == null)
                {
                    //	Console.WriteLine ("StudentFind: Not Found {0} ", id);
                    return null;
                }
                else if (left != null && id < this.id)
                {
                    return left.FindStudent(id);
                }
                else if (right != null && id > this.id)
                {
                    return right.FindStudent(id);
                }
                else
                {
                    return null;
                }
            }

            public void Clear()
            {
                left = null;
                right = null;
            }

          
            public Point Location
            {
                get { return location; }
                private set { location = value; }
            }   
        }
 }

	
