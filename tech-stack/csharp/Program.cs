using System;

namespace csharp
{
    class A<T> {
        public T number;

        public void increment () {
            T i = this.number + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A<int> a = new A<int>();
            a.increment();
        }
    }
}
