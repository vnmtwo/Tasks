using NUnit.Framework;
using System;
using Tasks;

namespace Tests
{

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

            s = new string[] { "0", "1", null, null };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(s), 2);

            s = new string[] { "0", "1", null, null, "2", "2", "2" };
            Assert.AreEqual(ArrayOperations.MaxEqualSequenceLength(s), 3);

        }

        [Test]
        public void MaxEqualSequenceLength_ArgumentNullException()
        {
            Assert.Throws<NullReferenceException>(() =>
                ArrayOperations.MaxEqualSequenceLength<int>(null));
        }
    }
}

