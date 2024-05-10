using System;

namespace HiraKata_Kaizen {
    public static class ArrayExtensions {
        private static Random _random = new Random();

        public static void Shuffle<T>(this T[] array) {
            int n = array.Length; // len array
            while (n > 1) { // from the last element to the first
                int k = _random.Next(n--); // generate a random index k such that 0 <= k < n
                T temp = array[n - 1]; // use n - 1 because arrays are 0-based
                array[n - 1] = array[k];
                array[k] = temp;

                n--; // Decrement n to move to the next iteration
            }
        }
    }
}
