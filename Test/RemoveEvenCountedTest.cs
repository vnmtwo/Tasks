using NUnit.Framework;
using System;
using Tasks;

namespace Tests
{
    public class RemvoeEvenCountedTest
    {
        [Test]
        public void RemoveEvenCounted_Normal()
        {
            //value type

            int[] a = new int[] { 0, 1 };
            CollectionAssert.AreEqual(ArrayOperations.RemoveEvenCounted(a), a);

            a = new int[] { 0, 1, 1 };
            CollectionAssert.AreEqual(ArrayOperations.RemoveEvenCounted(a), new int[] { 0 });

            a = new int[0];
            CollectionAssert.AreEqual(ArrayOperations.RemoveEvenCounted(a), a);

            //reference type

            string[] sa = new string[] { "0", "1" };
            CollectionAssert.AreEqual(ArrayOperations.RemoveEvenCounted(sa), sa);

            sa = new string[] { "0", "1", "1" };
            CollectionAssert.AreEqual(ArrayOperations.RemoveEvenCounted(sa), new string[] { "0" });

            sa = new string[0];
            CollectionAssert.AreEqual(ArrayOperations.RemoveEvenCounted(sa), sa);
        }

        [Test]
        public void RemoveEvenCounted_ArgumentNullException()
        {
            Assert.Throws<NullReferenceException>(()=>
                ArrayOperations.RemoveEvenCounted<int>(null));

            Assert.Throws<ArgumentNullException>(() =>
                ArrayOperations.RemoveEvenCounted<string>(new string[] { null, "1" }));
        }
    }
}