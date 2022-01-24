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
            Assert.Throws<ArgumentNullException>(()=>
                ArrayOperations.RemoveEvenCounted<int>(null));
        }
    }

    public class MaxEqualSequenceLengthTest
    {
        [Test]
        public void MaxEqualSequenceLength_Normal()
        {
            //value type
            int[] a = new int[0];
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(a), 0);

            a = new int[] { 0, 0 };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(a), 2);

            a = new int[] { 0, 0, 1 };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(a), 2);

            a = new int[] { 0, 1, 1 };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(a), 2);

            a = new int[] { 0, 1, 1, 0 };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(a), 2);

            //reference type
            string[] s = new string[0];
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(s), 0);

            s = new string[] { "0", "0" };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(s), 2);

            s = new string[] { "0", "0", "1" };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(s), 2);

            s = new string[] { "0", "1", "1" };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(s), 2);

            s = new string[] { "0", "1", "1", "0" };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(s), 2);
        }

        [Test]
        public void MaxEqualSequenceLength_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() =>
                ArrayOperations.MaxEqualSequenceLength<int>(null));

            Assert.Throws<ArgumentNullException>(() =>
                ArrayOperations.MaxEqualSequenceLength(new string[] { "1", null, "2" }));
        }
    }
}