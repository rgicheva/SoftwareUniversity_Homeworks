package Lection2;

import java.util.Scanner;

public class _8_CountOfEqualBitPairs {

	public static void main(String[] args) {
		System.out.print("Please enter an integer number:");
		Scanner scan = new Scanner(System.in);
		int n = scan.nextInt();
        int bit = 0;
        int counter = 0;
        int foundPairs = 0;

        while (n > 0)
        {
            
            if ((n & 1) == 1 && bit == 0)
            {
                counter = 0;
                bit = 1;
            }

            if ((n & 1) == 0 && bit == 1)
            {
                counter = 0;
                bit = 0;
            }

            if ((n & 1) == 1)
            {
                bit = 1;
            }
            else
            {
                bit = 0;
            }

            if ((n & 1) == 1 && bit == 1)
            {
                counter++;
                if (counter == 2)
                {
                    foundPairs++;
                    counter = 1;
                }
            }

            if ((n & 1) == 0 && bit == 0)
            {
                counter++;
                if (counter == 2)
                {
                    foundPairs++;
                    counter = 1;
                }
            }

            n = n >> 1;
        }
		System.out.println(foundPairs);
	}
}

