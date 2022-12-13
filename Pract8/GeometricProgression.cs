using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Pract8
{
    internal class GeometricProgression : ISeries//наследуем данные из интерфейса
    {
        private int _firstValue, _secondValue;
        private double _step;
        public GeometricProgression(int firstValue, int secondValue)//конструктор
        {
            _firstValue = firstValue;
            _secondValue = secondValue;
            _step = secondValue / firstValue;//ищем шаг путем деления второго значения на первое
        }
        public int FirstValue//свойство
        {
            get { return _firstValue; }
            set { _firstValue = value; }
        }
        public int SecondValue//свойство
        {
            get { return _secondValue; }
            set { _secondValue = value; }
        }
        public double Step//свойство
        {
            get { return _step; }
            set { _step = value; }
        }
        
        public int CompareTo(object obj)//сравнение
        {
            GeometricProgression progression = (GeometricProgression)obj;//сравниваем первую прогрессию со второй
            double step1=progression.Step;
            double step2=this.Step;
            return step2.CompareTo(step1);//выводим шаг большей прогрессии
        }
       
        public GeometricProgression ShallowClone()//поверхностное клонирование(не используется)
        {
            return (GeometricProgression)MemberwiseClone();
        }

        public object Clone()//полное клонирование(не используется)
        {
            return new GeometricProgression(FirstValue,SecondValue);
        }
    }
}
