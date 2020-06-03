using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Реалізувати клас, що представляє арифметичну прогресію.
 * Передбачити індексатор для одержання i -го члена прогресії, методи введення/виведення, 
 * знаходження суми n членів цієї прогресії.*/
namespace Lab_3_OOP_Block_1
{
    class ArifmeticalProgression
    {
       
        int n1;
        int n2;

        public ArifmeticalProgression(int n1_, int n2_)
        {
        n1 = n1_;
        n2 = n2_;
        }
        public int this[int i]
        {
            get
            {
                return n1 + (n2 - n1) * (i - 1);
            }
        }
            public int Suma(int i)
        {
            return (int)(((double)(n1 + this[i])/2)*i);
        }

    }
        }