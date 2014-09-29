package Lection1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class _6_SumTwoNumbers {

	public static void main(String[] args) throws IOException {
	
	BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
	System.out.print("Please enter two Strings: ");
	String n1 = br.readLine();
	String n2 = br.readLine();
	int s1 = Integer.parseInt(n1);
	int s2 = Integer.parseInt(n2);
	int s3 = s1 + s2;
	System.out.print("The sum of the numbers you enter is:" + s3);
	}
}