/* *****************************************************************************
 *  Name:              Mina Nicola
 *  Coursera User ID:  aa78e0a7c9454547c92cb9c7bd076dfe
 *  Last modified:     December 27, 2022
 **************************************************************************** */

import edu.princeton.cs.algs4.StdIn;
import edu.princeton.cs.algs4.StdOut;
import edu.princeton.cs.algs4.StdRandom;

public class RandomWord {
    public static void main(String[] args) {

        String champ = "";
        double i = 1.0;
        while (!StdIn.isEmpty()) {
            String contestingChamp = StdIn.readString();
            if (StdRandom.bernoulli(1.0 / i)) {
                champ = contestingChamp;
            }
            i++;
        }
        StdOut.print(champ);
    }
}
