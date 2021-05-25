using Unity.Jobs;
using Unity.Mathematics;

namespace MyNamespace {
    public struct TestJob : IJob {
        public int2 start;
        public int2 goal;

        private int2 diff;

        public void Execute() {
            // diff = goal - start;
        }
    }

    public class A {
        public A B = null;
    }
}


// namespace OtherNamespace {
//     public interface IOtherInterface { }
//
//     public class OtherClass : IOtherInterface { }
//
//     public class TestScript : MonoBehaviour { }
// }
