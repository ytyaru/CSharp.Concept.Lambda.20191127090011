using System;
using System.Threading.Tasks;

namespace Concept.Lambda.Lesson2 {
    class Main {
        public void Run() {
            var task = Run0();
            task.Wait();
        }
        private async Task Run0() {
            Func<Task> act = async () => {
                int wait = 2000;
                Console.WriteLine($"{wait}ミリ秒待機中……");
//                await Task.Delay(wait);
                await Task.Delay(wait).ConfigureAwait(false);
                Console.WriteLine($"非同期ラムダ式。（文）");
            };
            await act();
        }
    }
}
