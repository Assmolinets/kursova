using System.ComponentModel.Design.Serialization;

namespace Kursova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Tree tree = new Tree();
            this.Width = 816;
            this.Height = 489;
        }

        public class Unit
        {
            public string name;
            public char sex;
            public int? age;
            public Unit husband;
            public Unit wife;
            public Unit mother;
            public Unit father;
            public Unit sister;
            public Unit brother;
            public Unit dauther;
            public Unit son;

            public Unit(string name, char sex, int? age)
            {
                this.name = name;
                mother = null;
                father = null;
                sister = null;
                brother = null;
                dauther = null;
                son = null;
                this.sex = sex;
                this.age = age;
            }
        }

        class Tree
        {
            private Unit head;
            private List<Unit> list;

            public Tree()
            {
                head = null;
                list = new List<Unit>();
            }
            public void AddUnit(string unit, char sex, int? age, string parent, string name)
            {
                Unit newUnit = new Unit(unit, sex, age);
                if (head == null)
                {
                    head = newUnit;
                    list.Add(newUnit);
                }
                else
                {
                    AddUnit(newUnit, parent, name, head, false);
                }
            }
            private Unit AddUnit(Unit unit, string parent, string name, Unit curr, bool have_parent)
            {
                if (curr.name == name)
                {
                    if (parent == "love")
                    {
                        if (curr.sex == 'm')
                        {
                            unit.husband = curr;
                            curr.wife = unit;
                        }
                        else if (curr.sex == 'f')
                        {
                            unit.wife = curr;
                            curr.husband = unit;
                            if (curr == head)
                            {
                                unit = head;
                            }
                        }
                    }
                    if (parent == "parent")
                    {
                        if (unit.sex == 'f')
                        {
                            if (curr.sex == 'm')
                            {
                                unit.son = curr;
                                curr.mother = unit;
                                if (curr == head)
                                {
                                    unit = head;
                                }
                            }
                            else if (curr.sex == 'f')
                            {
                                unit.dauther = curr;
                                curr.mother = unit;
                                if (curr == head)
                                {
                                    unit = head;
                                }
                            }
                        }
                        else if (unit.sex == 'm')
                        {
                            if (curr.sex == 'm')
                            {
                                unit.son = curr;
                                curr.father = unit;
                                if (curr == head)
                                {
                                    unit = head;
                                }
                            }
                            else if (curr.sex == 'f')
                            {
                                unit.dauther = curr;
                                curr.father = unit;
                                if (curr == head)
                                {
                                    unit = head;
                                }
                            }
                        }
                    }
                    if (parent == "br/sis")
                    {
                        if (unit.sex == 'f')
                        {
                            if (curr.sex == 'm')
                            {
                                unit.brother = curr;
                                curr.sister = unit;
                            }
                            else if (curr.sex == 'f')
                            {
                                unit.sister = curr;
                                curr.sister = unit;
                            }
                        }
                        else if (unit.sex == 'm')
                        {
                            if (curr.sex == 'm')
                            {
                                unit.brother = curr;
                                curr.brother = unit;
                            }
                            else if (curr.sex == 'f')
                            {
                                unit.sister = curr;
                                curr.brother = unit;
                                if (curr == head)
                                {
                                    unit = head;
                                }
                            }
                        }
                    }
                    if (parent == "child")
                    {
                        if (unit.sex == 'f')
                        {
                            if (curr.sex == 'm')
                            {
                                unit.father = curr;
                                curr.dauther = unit;
                            }
                            else if (curr.sex == 'f')
                            {
                                unit.mother = curr;
                                curr.dauther = unit;
                            }
                        }
                        else if (unit.sex == 'm')
                        {
                            if (curr.sex == 'm')
                            {
                                unit.father = curr;
                                curr.son = unit;
                            }
                            else if (curr.sex == 'f')
                            {
                                unit.mother = curr;
                                curr.son = unit;
                            }
                        }
                    }
                    Research(unit, curr);
                    list.Add(unit);
                    return unit;
                }
                else
                {
                    if (curr != null)
                    {
                        if (!have_parent)
                        {
                            curr.husband = AddUnit(unit.husband, parent, name, curr, true);
                            curr.wife = AddUnit(unit.wife, parent, name, curr, true);
                            curr.sister = AddUnit(unit.sister, parent, name, curr, true);
                            curr.brother = AddUnit(unit.brother, parent, name, curr, true);
                            curr.son = AddUnit(unit.son, parent, name, curr, false);
                            curr.dauther = AddUnit(unit.dauther, parent, name, curr, false);
                        }
                    }
                    return null;
                }
            }
            private void Research(Unit unit1, Unit unit2)
            {
                if (unit1.husband == unit2 || unit1.wife == unit2)
                {
                    unit1.son = unit2.son;
                    unit1.dauther = unit2.dauther;
                    if (unit1.sex == 'm')
                    {
                        unit1.son.father = unit1;
                        unit1.dauther.father = unit1;
                    }
                    else
                    {
                        unit1.son.mother = unit1;
                        unit1.dauther.mother = unit1;
                    }
                }
                if (unit1.son == unit2 || unit1.dauther == unit2)
                {
                    if (unit1.sex == 'f' && unit2.father != null)
                    {
                        unit1.husband = unit2.father;
                        unit1.dauther = unit1.husband.dauther;
                        unit1.son = unit1.husband.son;
                        if (unit1.dauther != null)
                        {
                            unit1.dauther.mother = unit1;
                        }
                        if (unit1.son != null)
                        {
                            unit1.son.mother = unit1;
                        }
                    }
                    if (unit1.sex == 'm' && unit2.mother != null)
                    {
                        unit1.wife = unit2.mother;
                        unit1.dauther = unit1.wife.dauther;
                        unit1.son = unit1.wife.son;
                        if (unit1.dauther != null)
                        {
                            unit1.dauther.father = unit1;
                        }
                        if (unit1.son != null)
                        {
                            unit1.son.father = unit1;
                        }
                    }
                }
                if (unit1.brother == unit2 || unit1.sister == unit2)
                {
                    if (unit2.mother != null)
                    {
                        unit1.mother = unit2.mother;
                        if (unit1.sex == 'f')
                        {
                            unit1.mother.dauther = unit1;
                        }
                        if (unit1.sex == 'm')
                        {
                            unit1.mother.son = unit1;
                        }
                    }
                    if (unit2.father != null)
                    {
                        unit1.father = unit2.father;
                        if (unit1.sex == 'f')
                        {
                            unit1.father.dauther = unit1;
                        }
                        if (unit1.sex == 'm')
                        {
                            unit1.father.son = unit1;
                        }
                    }
                }
                if (unit1.father == unit2)
                {
                    if (unit2.son != null)
                    {
                        if (unit1.sex == 'f')
                        {
                            unit1.brother = unit2.son;
                            if (unit1.wife != null)
                            {
                                unit1.mother = unit2.wife;
                                unit1.mother.dauther = unit1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("error_gender");
                            return;
                        }
                    }
                    if (unit2.dauther != null)
                    {
                        if (unit1.sex == 'm')
                        {
                            unit1.sister = unit2.dauther;
                            if (unit2.wife != null)
                            {
                                unit1.mother = unit2.wife;
                                unit1.mother.son = unit1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("error_gender");
                            return;
                        }
                    }
                }
                if (unit1.mother == unit2)
                {
                    if (unit2.son != null)
                    {
                        if (unit1.sex == 'f')
                        {
                            unit1.brother = unit2.son;
                            if (unit1.husband != null)
                            {
                                unit1.father = unit2.husband;
                                unit1.father.dauther = unit1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("error_gender");
                            return;
                        }
                    }
                    if (unit2.dauther != null)
                    {
                        if (unit1.sex == 'm')
                        {
                            unit1.sister = unit2.dauther;
                            if (unit2.husband != null)
                            {
                                unit1.father = unit2.husband;
                                unit1.father.son = unit1;
                            }
                        }
                        else
                        {
                            Console.WriteLine("error_gender");
                            return;
                        }
                    }
                }
            }

            public void Delete(string name)
            {
                Delete(head, name, false);
            }

            private Unit Delete(Unit curr, string name, bool have_parent)
            {
                if (curr.name == name)
                {
                    Forget(curr);
                    list.Remove(curr);
                    return curr;
                }

                if (have_parent == true)
                {
                    curr.wife = Delete(curr.wife, name, true);
                    curr.husband = Delete(curr.husband, name, true);
                    curr.sister = Delete(curr.sister, name, true);
                    curr.brother = Delete(curr.brother, name, true);
                    curr.son = Delete(curr.son, name, false);
                    curr.dauther = Delete(curr.dauther, name, false);
                }
                return curr;
            }

            private void Forget(Unit curr)
            {
                if (curr.son != null || curr.sister != null)
                {
                    MessageBox.Show("Не можна видалити родичів, якщо ті мають дітей");
                }
                else
                {
                    if (curr.sex == 'm')
                    {
                        if (curr.sister != null)
                        {
                            curr.sister.brother = null;
                            curr.sister = null;
                        }
                        if (curr.father != null)
                        {
                            curr.father.son = null;
                            curr.father = null;
                        }
                        if (curr.mother != null)
                        {
                            curr.mother.son = null;
                            curr.mother = null;
                        }
                        if (curr.wife != null)
                        {
                            curr.wife.husband = null;
                            curr.wife = null;
                        }
                    }
                    else
                    {
                        if (curr.brother != null)
                        {
                            curr.brother.sister = null;
                            curr.brother = null;
                        }
                        if (curr.father != null)
                        {
                            curr.father.dauther = null;
                            curr.father = null;
                        }
                        if (curr.mother != null)
                        {
                            curr.mother.dauther = null;
                            curr.mother = null;
                        }
                        if (curr.husband != null)
                        {
                            curr.husband.wife = null;
                            curr.husband = null;
                        }
                    }
                }
                curr = null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = @"C:\Users\CTAC\Documents\MyCodes\Kursova\family.txt";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "Hello world");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private async void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
