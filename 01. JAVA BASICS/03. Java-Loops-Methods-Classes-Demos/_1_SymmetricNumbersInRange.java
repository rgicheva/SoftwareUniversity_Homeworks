package Lection3;

import java.util.Scanner;

public class _1_SymmetricNumbersInRange {

	public static void main(String[] args) {
		System.out.print("Please enter two number separeted by space:");
        Scanner in = new Scanner(System.in);
        int a = in.nextInt();
        int b = in.nextInt();
        
        String firstNumber = Integer.toString(a);
        String secondNumber = Integer.toString(b);

        
        for (int i = a; i <= b; i++) { 
        		String numberAsString = Integer.toString((Integer) i);
        		if (numberAsString[0] == numberAsString[numberAsString.length() - 1]) {
        			System.out.println(numberAsString);
        		}
    
        		}
        }
	}

