using System;

namespace lab4
{
    internal class Program
    {
        public interface ISpeak
        {
            public void Speak();
        }

        private static void Main(string[] args)
        {
            Lion lion = new Lion();
            Console.WriteLine(lion.IsPredator);
            Birds bird = new Birds();
            Owl owl = new Owl();
            Crocodile crocodile = new Crocodile(11, 125, "amogus");
            Console.WriteLine("crocodile speak:");
            crocodile.Speak();
        }

        public abstract class Animals : ISpeak
        {
            protected int age;
            protected string name;
            protected int weigth;

            public Animals()
            {
                this.age = 0;
                this.name = null;
                this.weigth = 0;
            }

            public int Age
            {
                get => this.age;
                set => this.age = value;
            }

            public string Name
            {
                get => this.name;
                set => this.name = value;
            }

            public int Weight
            {
                get => this.weigth;
                set => this.weigth = value;
            }

            public void Speak()
            {
                Console.WriteLine("ty cho na");
            }

            public override string ToString()
            {
                return "class animals";
            }
        }

        public class Birds : Animals
        {
            private bool _hasWings;

            public Birds()
            {
                this._hasWings = true;
            }

            public bool HasWings => this._hasWings;

            public override string ToString()
            {
                Console.WriteLine("class Birds");
                return "class Birds";
            }
        }

        public class Printer
        {
            public void IAmPrinting(Animals someObj)
            {
                someObj.ToString();
            }
        }

        private abstract class BaseClone
        {
            public abstract bool DoClone();
        }

        private class Crocodile : Animals
        {
            public Crocodile(int age, int weigth, string name)
            {
                Age = age;
                Weight = weigth;
                Name = name;
            }

            public void Speak()
            {
                Console.WriteLine("yo bro");
            }

            public override string ToString()
            {
                Console.WriteLine("class crocodile");
                return "class crocodile";
            }
        }

        private class Fish : Animals
        {
            protected bool _canSwim;

            public Fish()
            {
                this._canSwim = true;
            }

            public override string ToString()
            {
                Console.WriteLine("class Fish");
                return "class Fish";
            }
        }

        private class Lion : Mammals
        {
            public Lion()
            {
                IsPredator = true;
            }

            public void Speak()
            {
                Console.WriteLine("lev klichka tigar");
            }

            public override string ToString()
            {
                Console.WriteLine("class Lion");
                return base.ToString();
            }
        }

        private class Mammals : Animals
        {
            protected bool _isMammal;
            protected bool _isPredator;

            public Mammals()
            {
                this._isMammal = true;
            }

            public bool IsMammal => this._isMammal;

            public bool IsPredator
            {
                get => this._isPredator;
                set => this._isPredator = value;
            }
        }

        private class Owl : Birds
        {
            public Owl()
            {
            }

            public void Speak()
            {
                Console.WriteLine("kurlyk kurlyk");
            }

            public override string ToString()
            {
                Console.WriteLine("class Owl");
                return base.ToString();
            }
        }

        private class Parrot : Birds
        {
            public void Speak()
            {
                Console.WriteLine("ispantsyyyy");
            }

            public override string ToString()
            {
                Console.WriteLine("class Parrot");
                return base.ToString();
            }
        }

        private sealed class Shark : Fish, ISpeak
        {
            public void Speak()
            {
                Console.WriteLine("baby shark turururu");
            }

            public override string ToString()
            {
                Console.WriteLine("Class Shark");
                return base.ToString();
            }
        }

        private class Tiger : Mammals
        {
            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            public void Speak()
            {
                Console.WriteLine("meow");
            }

            public override string ToString()
            {
                return "class Tiger";
            }
        }
    }
}