using System;

namespace Concept.Lambda.Lesson1 {
    class Main {
        public void Run() {
            Run0();
        }
        /*
        public void Run() => {
            Console.WriteLine("ラムダ式。（文）");
            Console.WriteLine("ラムダ式。（文）二行目。");
        };
        */
        private void Run0() {
            Action<int> act = param => {
                Console.WriteLine($"ラムダ式。（文）: {param}");
                Console.WriteLine($"ラムダ式。（文）二行目。: {param}");
            };
            act(100);
        }
    }
}
