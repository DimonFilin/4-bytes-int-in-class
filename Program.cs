using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_byte_int
{
    // тип4-разрядных данных.
    class Nybble
    {
        int val; // базовый тип для хранения данных
        public Nybble() { val = 0; }
        public Nybble(int i)
        {
            val = i;
            val = val & 0xF; // сохранить 4 младших разряда
        }

        // + для двух объектов типа Nybble.
        public static Nybble operator +(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = op1.val + op2.val;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        // + для объекта типа Nybble и значения типа int.
        public static Nybble operator +(Nybble op1, int op2)
        {
            Nybble result = new Nybble();
            result.val = op1.val + op2;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        // + для значения типа int и объекта типа Nybble.
        public static Nybble operator +(int op1, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = op1 + op2.val;

            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }

        public static Nybble operator -(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = op1.val - op2.val;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        // - для объекта типа Nybble и значения типа int.
        public static Nybble operator -(Nybble op1, int op2)
        {
            Nybble result = new Nybble();
            result.val = op1.val - op2;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        // - для значения типа int и объекта типа Nybble.
        public static Nybble operator -(int op1, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = op1 - op2.val;

            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }

        public static Nybble operator *(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = op1.val * op2.val;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        // * для объекта типа Nybble и значения типа int.
        public static Nybble operator *(Nybble op1, int op2)
        {
            Nybble result = new Nybble();
            result.val = op1.val * op2;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        // + для значения типа int и объекта типа Nybble.
        public static Nybble operator *(int op1, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = op1 * op2.val;

            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }

        public static Nybble operator /(Nybble op1, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = op1.val / op2.val;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        // / для объекта типа Nybble и значения типа int.
        public static Nybble operator /(Nybble op1, int op2)
        {
            Nybble result = new Nybble();
            result.val = op1.val / op2;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        // / для значения типа int и объекта типа Nybble.
        public static Nybble operator /(int op1, Nybble op2)
        {
            Nybble result = new Nybble();
            result.val = op1 / op2.val;

            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }


        // ++.
        public static Nybble operator ++(Nybble op)
        {
            Nybble result = new Nybble();
            result.val = op.val + 1;
            result.val = result.val & 0xF; // сохранить 4 младших разряда
            return result;
        }
        //  оператор >.
        public static bool operator >(Nybble op1, Nybble op2)
        {
            if (op1.val > op2.val) return true;
            else return false;
        }
        //  оператор <.
        public static bool operator <(Nybble op1, Nybble op2)
        {
            if (op1.val < op2.val) return true;
            else return false;
        }
        // оператор ==
        public static bool operator ==(Nybble op1, Nybble op2)
        {
            if (op1.val == op2.val) return true;
            else return false;
        }
        // оператор !=
        public static bool operator !=(Nybble op1, Nybble op2)
        {
            if (op1.val != op2.val) return true;
            else return false;
        }
        // Преобразовать тип Nybble в тип int.
        public static implicit operator int(Nybble op)
        {
            return op.val;
        }
        // Преобразовать тип int в тип Nybble.
        public static implicit operator Nybble(int op)
        {
            return new Nybble(op);
        }
    }
    class NybbleDemo
    {
        static void Main()
        {
            int t;


            Console.WriteLine("Введите первое 4-разрядное число");
            Nybble a = new Nybble(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите второе 4-разрядное число");
            Nybble b = new Nybble(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите третье 4-разрядное число");
            Nybble c = new Nybble(Convert.ToInt32(Console.ReadLine()));

            Console.Clear();
            Console.WriteLine("a =" + (int)a);
            Console.WriteLine("b =" + (int)b);
            Console.WriteLine("c =" + (int)c);

            //Сравнение
            if (a < b) Console.WriteLine("а меньше b\n");
            else if (a > b) Console.WriteLine("а больше b\n");
            else if (a == b) Console.WriteLine("а = b\n");


            c = a + b;
            Console.WriteLine("с после операции с = а + b: " + (int)c);

            a += 5;
            Console.WriteLine("а после операции а += 5: " + (int)a);

            t = a * 2 + 3;
            Console.WriteLine("Результат вычисления выражения а * 2 + 3: " + t);

            t = a / b * c;
            Console.WriteLine("Результат вычисления выражения a / b * c: " + t);

            //Привсоенае int to Nybble
            Console.WriteLine("Присвоим и переполним значение a = 19");
            a = 19;
            Console.WriteLine("Результат присваивания а = 19: " + (int)a + " так как максимум - 16");
            Console.ReadLine();
        }
    }
}
